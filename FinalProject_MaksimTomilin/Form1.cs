using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_MaksimTomilin
{
    public partial class Form1 : Form
    {
        int rightNumbers;
        int objectiveNum = 1;
        int scoreCount;
        int allPercentage;
        int totalScore;
        public Form1()
        {
            List<int> objectiveNums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            InitializeComponent();
            objective(objectiveNum);
            totalScore = 10;
            string message = "Welcome to Countries Quiz Game! " + "There will be 10 questions related to countries and their capitals, at the end a counter of correct answers and a percentage will be displayed, good luck!";
            MessageBox.Show(message);
        }

        private void verifyButton(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == rightNumbers)
            {
                scoreCount++;
            }
            
            if(objectiveNum == totalScore)
            {
                allPercentage = (int)Math.Round((double)(scoreCount * 100) / totalScore);
                DialogResult dialogResult = MessageBox.Show("You have completed the quiz. " + "You answered correctly " + scoreCount + " questions. " +
                    "The total number of correct answers is exactly " 
                    + allPercentage + "%. " + "If you would like to start over, click *Yes* button.","Results", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                   
                }
                else
                {
                    Application.Exit();
                }
                scoreCount = 0;
                objectiveNum = 0;
                objective(objectiveNum);
            }
            objectiveNum++;
            objective(objectiveNum);
        }
        private void objective(int qnum) 
        {
            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.FlagOfEstonia;
                    labelQuestion.Text = "Name the flag of the country";
                    button1.Text = "Pljevlja, Serbia";
                    button3.Text = "Finland";
                    button2.Text = "Argentina";
                    button4.Text = "Estonia";
                    rightNumbers = 4;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.FlagOfPeru;
                    labelQuestion.Text = "Name the flag of the country";
                    button1.Text = "Indonesia";
                    button3.Text = "Monaco";
                    button2.Text = "Peru";
                    button4.Text = "Norway";
                    rightNumbers = 2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.FlagOfUruguay;
                    labelQuestion.Text = "Name the flag of the country";
                    button1.Text = "Uruguay";
                    button3.Text = "Chile";
                    button2.Text = "Colombia";
                    button4.Text = "Ecuador";
                    rightNumbers = 1;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Madrid;
                    labelQuestion.Text = "Name the country of this capital - Madrid";
                    button1.Text = "Spain";
                    button3.Text = "Portugal";
                    button2.Text = "France";
                    button4.Text = "Italy";
                    rightNumbers = 1;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.FlagOfAustria;
                    labelQuestion.Text = "Name the flag of the country";
                    button1.Text = "Singapore";
                    button3.Text = "Austria";
                    button2.Text = "Hungary";
                    button4.Text = "Canada";
                    rightNumbers = 3;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.FlagOfIndonesia;
                    labelQuestion.Text = "Name the flag of the country";
                    button1.Text = "Poland";
                    button3.Text = "Denmark";
                    button2.Text = "Switzerland";
                    button4.Text = "Indonesia";
                    rightNumbers = 4;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.Stockholm;
                    labelQuestion.Text = "Name the country of this capital - Stockholm";
                    button1.Text = "Norway";
                    button3.Text = "Iceland";
                    button2.Text = "Sweden";
                    button4.Text = "Finland";
                    rightNumbers = 2;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.FlagOfThePhilippines;
                    labelQuestion.Text = "Name the flag of the country";
                    button1.Text = "Malaysia";
                    button3.Text = "Czech Republic";
                    button2.Text = "Puerto Rico";
                    button4.Text = "Philippines";
                    rightNumbers = 4;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.Beijing;
                    labelQuestion.Text = "Name the country of this capital - Beijing";
                    button1.Text = "Turkey";
                    button3.Text = "China";
                    button2.Text = "Vietnam";
                    button4.Text = "Morocco";
                    rightNumbers = 3;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.FlagOfFinland;
                    labelQuestion.Text = "Name the flag of the country";
                    button1.Text = "Finland";
                    button3.Text = "Latvia";
                    button2.Text = "Norway";
                    button4.Text = "Iceland";
                    rightNumbers = 1;
                    break;

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
