using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_9_Klein
{
    public partial class Form1 : Form
    {
        private int[] random1 = new int[100];
        private int[] random2 = new int[100];
        private int iterationCount = 0;
        private int rightAnswers = 0;
        private int wrongAnswers = 0;
        
        public Form1()
        {            
            InitializeComponent();
            fillArrays();
            correctCountLabel.Text = rightAnswers.ToString();
            wrongCountLabel.Text = wrongAnswers.ToString();
        }

        public void fillArrays()
        {
            Random randNum = new Random();

            for(int a = 0; a < random1.Length; a++)
            {
                random1[a] = randNum.Next(0,100);
                random2[a] = randNum.Next(0, 100);
            }
        }
        
        private void disableAnswerButtons()
        {
            option1Bttn.Enabled = false;
            option2Bttn.Enabled = false;
        }

        private void showAnswer()
        {
            int answer1 = random1[iterationCount];
            int answer2 = random2[iterationCount];

            result1Label.Text = answer1.ToString();
            result2Label.Text = answer2.ToString();            
        }

        private void option1Bttn_Click(object sender, EventArgs e)
        {
            disableAnswerButtons();
            showAnswer();

            if(Convert.ToInt32(result1Label.Text) > Convert.ToInt32(result2Label.Text))
            {
                rightAnswers++;
            }
            else
            {
                wrongAnswers++;
            }
            correctCountLabel.Text = rightAnswers.ToString();
            wrongCountLabel.Text = wrongAnswers.ToString();
        }

        private void option2Bttn_Click(object sender, EventArgs e)
        {
            disableAnswerButtons();
            showAnswer();
            if(Convert.ToInt32(result1Label.Text) < Convert.ToInt32(result2Label.Text))
            {
                rightAnswers++;
            }
            else
            {
                wrongAnswers++;
            }
            correctCountLabel.Text = rightAnswers.ToString();
            wrongCountLabel.Text = wrongAnswers.ToString();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            iterationCount++;
            result1Label.Text = "?";
            result2Label.Text = "?";
            option1Bttn.Enabled = true;
            option2Bttn.Enabled = true;

            if(iterationCount == random1.Length)
            {
                fillArrays();
                iterationCount = 0;                
            }
        }        
    }
}
