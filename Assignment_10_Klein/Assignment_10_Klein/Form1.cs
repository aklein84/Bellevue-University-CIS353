using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment_10_Klein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void NavTab_Change(object sender, EventArgs e)
        {
            clearScreen();
        }

        private void AddFriendBttn_Click(object sender, EventArgs e)
        {
            addEntry();            
        }

        private void ReadBttn_Click(object sender, EventArgs e)
        {
            readFromFile();
        }

        private void ReminderButton_Click(object sender, EventArgs e)
        {
                if (SearchMonthTextBox.Text != "")
                {                    
                    displayReminder(SearchMonthTextBox.Text);
                }
                else
                {
                    MessageBox.Show("Please enter month into the search box...", "No search criteria");
                    //SearchMonthTextBox.BackColor = Color.Red;
                }
        }

        private void ExitBttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitBttnTB2_Click(object sender, EventArgs e)
        {
            ExitBttn_Click(sender, e);
        }

        private void ReminderTabExitBttn_Click(object sender, EventArgs e)
        {
            ExitBttn_Click(sender, e);
        }

        private void writeToFile(string entry)
        {
            FileStream writeFile = new FileStream("Friends.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(writeFile);
            writer.WriteLine(entry);
            MessageBox.Show(entry + " added to file.");

            writer.Close();
            writeFile.Close();
            writer.Dispose();
            writeFile.Dispose();
        }

        private void readFromFile()
        {
            string[] fields;
            FileStream readFile = new FileStream("Friends.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(readFile);
            string entryLine = reader.ReadLine();
            while (entryLine != null)
            {                
                fields = entryLine.Split(',');
                string firstname = fields[0];
                string lastname = fields[1];
                string phonenumber = fields[2];
                string dateOfBirth = fields[3] + "/" + fields[4];
                ReadFileTextBox.Text += firstname + "\t" + lastname + "\t" + phonenumber + "\t" + dateOfBirth + "\r\n";
                entryLine = reader.ReadLine();
            }             
            reader.Close();
            readFile.Close();            
        }

        private void addEntry()
        {
            Friend myFriend = new Friend();
            myFriend.FIRSTNAME = FirstNameTextBox.Text.Trim();
            myFriend.LASTNAME = LastNameTextBox.Text.Trim();
            myFriend.PHONENUMBER = PhoneTextBox.Text;

            try
            {
                myFriend.MONTH = Convert.ToInt32(MonthTextBox.Text);
            }
            catch
            {
                myFriend.MONTH = 1;
            }
            try
            {
                myFriend.DAY = Convert.ToInt32(BirthDayTextBox.Text);
            }
            catch
            {
                myFriend.DAY = 1;
            }

            writeToFile(myFriend.ToString());
            clearScreen();
        }

        private void clearScreen()
        {
            int navTabIndex = NavTab.SelectedIndex;
            foreach(Control control in NavTab.SelectedTab.Controls)
            {
                try
                {
                    TextBox tb = control as TextBox;
                    if(tb != null)
                    {
                        tb.Text = "";
                    }
                }
                catch
                {
                    return;
                }

                try
                {
                    MaskedTextBox mt = control as MaskedTextBox;
                    if(mt != null)
                    {
                        mt.Text = "";
                    }                    
                }
                catch
                {
                    return;
                }
            }               
        }

        private void displayReminder(string searchDate)
        {
            string[] fields;
            FileStream readFile = new FileStream("Friends.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(readFile);
            string entryLine = reader.ReadLine();
            while (entryLine != null)
            {
                fields = entryLine.Split(',');
                if (fields[3] == searchDate.TrimStart('0'))
                {
                    clearScreen();
                    string firstname = fields[0];
                    string lastname = fields[1];
                    string phonenumber = fields[2];
                    string dateOfBirth = fields[3] + "/" + fields[4];
                    RemindersTextBox.Text += firstname + "\t" + lastname + "\t" + phonenumber + "\t" + dateOfBirth + "\r\n";
                }
                entryLine = reader.ReadLine();
            }            
        }
    }

}
