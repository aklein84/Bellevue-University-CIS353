using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Klein
{
    class Accounts
    {
        // Declaring arrays
        private int[] acctNumbers = new int[5]; 
        private double[] acctBalance = new double[5];
        private string[] acctNames = new string[5];
        
        // Method to set values of arrays
        public void getAcctInfo()
        {
            for(int a = 0; a < acctNumbers.Length; a++) // For loop to address each array index
            {
                Console.Write("Please enter account number for account {0}: ",(a+1));
                acctNumbers[a] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter account balance for account {0}: ",(a+1));
                acctBalance[a] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter name of account for account {0}: ", (a+1));
                acctNames[a] = Console.ReadLine();

                Console.Write("\n");
            }
        }

        // Method to search for an account
        public void searchAcctInfo()
        {
            int acctNumSearch;

            Console.Write("\nPlease enter account number to search: ");
            acctNumSearch = Convert.ToInt32(Console.ReadLine());
            
            // Returns true if enter account number, acctNumSearch, is found within the acctNumbers array.
            bool acctFound = Array.IndexOf(acctNumbers, acctNumSearch) >= 0;

            if (acctFound == true)
            {
                int indexVal = Array.IndexOf(acctNumbers, acctNumSearch);

                Console.WriteLine("\nAccount Number: {0}", acctNumbers[indexVal]);
                Console.WriteLine("Account Balace: {0:C}", acctBalance[indexVal]);
                Console.WriteLine("Account Name: {0}\n", acctNames[indexVal]);
            }
            else
            {
                Console.WriteLine("\nYou entered an invalid account\n");
            }
        }

        // Method to return the average of account balances
        public void avgAccounts()
        {
            double arrAvg = (acctBalance.Sum() / acctBalance.Length);
            Console.WriteLine("\nThe average of the account balance is: {0:c}\n",arrAvg);
        }
    }

    class Assignment_2_Klein
    {
        // Set variable for while loop, to continuously loop.
        private static bool doLoop = true;

        static void Main(string[] args)
        {
            Accounts newAccount = new Accounts();
            newAccount.getAcctInfo();
            
            while (doLoop)
            {
                Console.WriteLine("*****************************************");
                Console.WriteLine("enter an a or A to search account numbers");
                Console.WriteLine("enter a b or B to average the accounts");
                Console.WriteLine("enter an x or X to exit program");
                Console.WriteLine("*****************************************");
                string userResponse = Console.ReadLine();

                switch (userResponse)
                {
                    case "a":
                    case "A":
                        {
                            newAccount.searchAcctInfo();
                            break;
                        }
                    case "b":
                    case "B":
                        {
                            newAccount.avgAccounts();
                            break;
                        }
                    case "x":
                    case "X":
                        {
                            doLoop = false; // If user requests to exit program, doLoop is set to false thus breaking the while loop. 
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        Console.WriteLine("\nYou enter an incorrect option.\n");
                        break;
                }
            }
        }
    }
}
