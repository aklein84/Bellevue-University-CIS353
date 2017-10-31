using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public delegate void PrintString(string r);

namespace Final_Project_Forms
{
    public partial class Form1 : Form
    {/*
        Declares all variables not initiated but an action
     */
        string type;
        string cone;
        string flavor;
        int scoop=0;
        string Fname;
        string Lname;
        string ID;
        string Cust;
        double Cost;
        string[,] Orders = new string[10,5];
        int OrderMax = 0;

    public Form1()
        {
            InitializeComponent();
        }
        /*
        Initiates Classes to be used
        */
        Cone Cone1 = new Cone();
        Order Order1 = new Order();
        Customer Cust1 = new Customer();
        Customer Cust2 = new Customer();


        /*
        Actions to complete when the Cone Button is pressed
        */
        private void btnCone_Click(object sender, EventArgs e)
        {   /*
            Initiates variables from text box for Customer Name and ID, then locks the text boxes until the end of the order
            */
            Fname = textBoxFName.Text;
            Lname = textBoxLName.Text;
            ID = textBoxID.Text;

            textBoxFName.Enabled=false;
            textBoxLName.Enabled = false;
            textBoxID.Enabled = false;


            /*
            Sets the type of Ice cream or Yogurt and then sets what cone was choosen
            */
            if (radioButtonIC.Checked == true)
            {
                type = "Ice Cream";
            }
            if (radioButtonFY.Checked == true)
            {
                type = "Frozen Yogurt";
            }
            if (radioWaffleCone.Checked == true)
            {
                cone = "Waffle Cone";
            }
            if (radioWaffleBowl.Checked == true)
            {
                cone = "Waffle Bowl";
            }
            if (radioSugarCone.Checked == true)
            {
                cone = "Sugar Cone";
            }
            if (radioBowl.Checked == true)
            {
                cone = "Bowl";
            }



            /*
            Checks inputs for no inut from user. if there was no input throws exception and warns user of action
            */
            try
            {

                if (Fname == "" || Lname == "" || ID == "" || type == null || cone == null || listBoxFlavor.SelectedItem == null || listBoxScopes.SelectedItem == null)
                {
                    throw new NullReferenceException();
                }
                else
                {
                    Cust = (ID + " " + Fname + " " + Lname);

                    /*
                    set flavor and scoops from listbox menu selections
                    */
                    flavor = listBoxFlavor.SelectedItem.ToString();
                    scoop = Convert.ToInt32(listBoxScopes.SelectedItem.ToString());

                    /*
                    starts building order and adds to the order with evey cone added
                    */
                    Orders = Cone1.ConeArray(type, cone, flavor, scoop);


                    /*
                    Creates the string to be printed and saved to file
                    */
                    Cust = Order1.CustomerString(Cust, Orders);
                    
                    /*
                    gets total cost of the order
                    */
                    Cost = Cone1.ConeCost();

                    /*
                    Displays total cost of the order
                    */
                    lblTotal.Text = ("Order total is:    $" + Cost.ToString());


                    /*
                    Displays the order into the Order Listbox for a reciept view
                    */
                    Order1.CreateReciept();
                    string Ordered = Order1.reciept();
                    string[] OrderA = Ordered.Split('/');

                    listBoxOrder.Items.Clear();
                    listBoxOrder.Items.Add(OrderA[0]);


                    for (int w = 1; w < OrderA.Length; w += 5)
                    {
                        int u = w + 4;
                        int x = w + 1;
                        int y = w + 2;
                        int z = w + 3;
                        string Tab;
                        string Tab2;

                        if (OrderA[y].Length >= 16)
                        {
                            Tab = "\t";
                        }
                        else if(OrderA[y].Length <= 8)
                        {
                            Tab = "\t\t\t";
                        }
                        else
                        {
                            Tab = "\t\t";
                        }

                        if (OrderA[x].Length <= 8)
                        {
                            Tab2 = "\t\t";
                        }
                        else
                        {
                            Tab2 = "\t";
                        }

                        if (OrderA[x] != null)
                        {
                            {
                               listBoxOrder.Items.Add(string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}", OrderA[w],"\t", OrderA[x], Tab2, OrderA[y], Tab, OrderA[z], "\t", OrderA[u]));
                            }

                        }


                        /*
                        resets the cone settings for user to selec new cone
                        */
                        listBoxFlavor.Items.Clear();
                        radioButtonIC.Checked = false;
                        radioButtonFY.Checked = false;
                        radioWaffleCone.Checked = true;
                        listBoxScopes.ClearSelected();
                        OrderMax++;

                        if (OrderMax == 10)
                            MessageBox.Show("You have Entered the max numbr of cones\n Please Press Button Below to Complete Order", "Order Maxed Out",MsgbtnComplete);
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Check All inputs");
            }



        }

        private void radioButtonFY_CheckedChanged(object sender, EventArgs e)
        {
            string[] ICflavor = { "Vanilla", "Chocolate", "Chocolate Chip", "Butter Peacan", "Chocolate Chocolate Chip", "Brownie", "Birthday Cake", "Swirl" };
            string[] FYflavor = { "Vanilla", "Chocolate", "Rasberry", "Cheesecake", "Peanut Butter", "Brownie", "Birthday Cake", "Mango" };

            listBoxFlavor.Items.Clear();

            if (radioButtonIC.Checked == true)
            {
                for (int x = 0; x < ICflavor.Length; x++)
                {

                    listBoxFlavor.Items.Add(ICflavor[x]);
                }
            }
            else if (radioButtonFY.Checked == true)
            {
                for (int x = 0; x < FYflavor.Length; x++)
                {

                    listBoxFlavor.Items.Add(FYflavor[x]);
                }
            }


        }

        private void radioButtonIC_CheckedChanged(object sender, EventArgs e)
        {
            string[] ICflavor = { "Vanilla", "Chocolate", "Chocolate Chip", "Butter Peacan","Chocolate Chocolate Chip","Brownie","Birthday Cake","Swirl"};
            string[] FYflavor = { "Vanilla", "Chocolate", "Rasberry", "Cheesecake", "Peanut Butter", "Brownie", "Birthday Cake", "Mango" };

            listBoxFlavor.Items.Clear();

            if(radioButtonIC.Checked==true)
            {
                for (int x=0;x<ICflavor.Length;x++)
                {

                listBoxFlavor.Items.Add(ICflavor[x]);
                }
            }
            if (radioButtonFY.Checked==true)
            {
                for (int x = 0; x < FYflavor.Length; x++)
                {

                    listBoxFlavor.Items.Add(FYflavor[x]);
                }
            }


        }

        private void textBoxFName_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxFName.Text.Contains(" "))
            {
                e.Cancel = true;
                MessageBox.Show("Pleaase Only include First name with no Spaces");
            }

            if (textBoxFName.Text == "")
            {
                e.Cancel = true;
                MessageBox.Show("Pleaase provide a First Name");
            }
        }

        private void textBoxLName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxLName.Text.Contains(" "))
            {
                e.Cancel = true;
                MessageBox.Show("Pleaase Only include Last name with no Spaces");
            }

            if (textBoxLName.Text == "")
            {
                e.Cancel = true;
                MessageBox.Show("Pleaase provide a Last Name");
            }
        }

        private void textBoxID_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxID.Text == "")
            {
                e.Cancel = true;
                MessageBox.Show("Pleaase provide an ID");
            }

            if (textBoxID.Text.Contains(" "))
            {
                e.Cancel = true;
                MessageBox.Show("Pleaase Only include ID with no Spaces");
            }
        }

        private void btnComplete_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxFName.Clear();
            textBoxLName.Clear();
            textBoxID.Clear();
            textBoxFName.Enabled = true;
            textBoxLName.Enabled = true;
            textBoxID.Enabled = true;
            listBoxFlavor.Items.Clear();
            radioButtonIC.Checked = false;
            radioButtonFY.Checked = false;
            radioWaffleCone.Checked = true;
            listBoxScopes.ClearSelected();
            listBoxOrder.Items.Clear();
            lblTotal.Text = "Order total is:    $0:00";

            Cone1.Reset();
            Cust1.Reset();
            Order1.ResetOrder();



            Cust2.CustomerFile(Cust, ID);
        }
    }

    class Cone
    {
        public string[,] Order = new string[10, 5];
        public static double ScoopPrice = .50;
        public static double ConePrice = .75;
        public int x = 0;
        double Cost;
        double Total;
        
        public string[,] ConeArray(string Type, string Cone, string Flavor, int Scoop)
        {
            Order[x, 0] = Type;
            Order[x, 1] = Cone;
            Order[x, 2] = Flavor;
            Order[x, 3] = Scoop.ToString();
            Cost = (Scoop * ScoopPrice + ConePrice);
            Order[x, 4] = Cost.ToString();

            Total += Cost;
            
            x++;

            return (Order);
        }

        public double ConeCost()
        {           

            return (Total);

        }

        public void Reset()
        {
            x = 0;

            for (int z = 0; z < 10; z++)
            {
                for (int y = 0; y < 5; y++)
                {
                    Order[z, y] = null;
                }
            }

            Total = 0;
        }

        public Cone()
        {

        }



    }

    class Customer
    {
        static public string FileName = Path.Combine(Environment.CurrentDirectory, "Ice Ceam Shop.txt");
        static public char DELIM = ' ';
        static public string line = null;
        public string CustOrder;


        public Customer()
        {

        }

        public void CustomerFile(string cust, string ID)
        {
            string[] Cust= new string[1];
            Cust[0] = cust;
            string tempFile = @"Temp.txt";

            if(!File.Exists(FileName))
            {
            File.Create(FileName).Close();
            }

            if (!File.Exists(tempFile))
            {
                File.Create(tempFile).Close();
            }


            var linesToKeep = File.ReadAllLines(FileName).Where(l=>l!=ID);

           File.WriteAllLines(tempFile, linesToKeep);
            File.WriteAllLines(tempFile, Cust);

           File.Delete(FileName);
           File.Move(tempFile, FileName);
        }

        public void Reset()
        {
            CustOrder = null;
        }
    }

    class Order:Customer
    {
        string Reciept;
        string[,] Ordered = new string[10, 5];
        public static double ScoopPrice = .50;
        public static double ConePrice = .75;

        public Order()
        {

        }

        public string CustomerString(string cust, string[,] order)
        {
            CustOrder = cust;

            for (int x = 0; x < 10; x++)
            {
                if (order[x, 0] != null)
                {
                    for (int y = 0; y < 5; y++)
                    {
                        CustOrder += (" / " + order[x, y]);
                    }
                }

            }

            return (CustOrder);
        }
        public void CreateReciept()
        {
            PrintString ps2 = new PrintString(WriteToScreen);



                    ps2(CustOrder);

                
        }

        public void WriteToScreen(string r)
        {
            Reciept = r;
        }

        public string reciept()
        {
            return (Reciept);
        }

        public void ResetOrder()
        {
            Reciept = null;

            for(int x =0;x<10;x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    Ordered[x, y] = null;
                }
            }
        }

    }
}






