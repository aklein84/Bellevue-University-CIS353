using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Assignment_7A_Klein
{
    class Assignment7 : Form
    {
        public Assignment7()
        {
            Button btnClickMe = new Button();
            btnClickMe.Text = "Press Me";
            btnClickMe.Location = new Point(15, 20);
            btnClickMe.Click += new EventHandler(btnClickMe_Click);
                        
            Button btnExit = new Button();
            btnExit.Text = "Exit";
            btnExit.Location = new Point(15, 60);
            btnExit.Click += new EventHandler(btnExit_Click);

            Text = "Assignment 8";
            Width = 300;
            Height = 150;
            Controls.Add(btnClickMe);            
            Controls.Add(btnExit);
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Button Has Been Clicked", "Click Me");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    class Assignment_7A_Klein
    {     
        static void Main(string[] args)
        {
            Console.Write("Press any key to continue...");
            Application.Run(new Assignment7());
            Console.ReadKey();
        }
    }
}
