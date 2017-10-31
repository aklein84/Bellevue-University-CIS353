using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_8_Klein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Select();
        }

        
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            const int shippingDays = 3;
            label4.Text = "Cookies will be delivered on: "+e.Start.AddDays(shippingDays).ToShortDateString();
        }

        private void calcCookiePrice()
        {
            double cookiePrice = 0;
            int[] cookieQTY = new int[4] { 6, 12, 24, 36 };

            int qtySelection = listBox1.SelectedIndex;
            if (radioButton1.Checked)
            {
                cookiePrice = .60;
            }
            else if (radioButton2.Checked)
            {
                cookiePrice = .75;
            }
            else if (radioButton3.Checked)
            {
                cookiePrice = .50;
            }
            try
            {
                double totalPrice = (cookiePrice * cookieQTY[qtySelection]);
                label5.Text = "Total is: " + totalPrice.ToString("c0");
            }
            catch
            {
                label5.Text = "Total is: ";
            }

        }
        
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            calcCookiePrice();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            calcCookiePrice();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            calcCookiePrice();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcCookiePrice();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Adam Klein 20170725.", "About Program");
        }
    }
}
