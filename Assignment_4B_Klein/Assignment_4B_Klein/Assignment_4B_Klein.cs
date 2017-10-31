using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4B_Klein
{
    public class Account
    {
        private int[] acctNum = new int[5];
        private double[] acctBal = new double[5];

        public void getData()
        {
            for (int a = 0; a < acctNum.Length; a++)
            {
                Console.Write("Please enter the account number: ");
                acctNum[a] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter the corresponding balance: ");
                acctBal[a] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
        }

        public void searchData()
        {
            Console.Write("Please enter the account number to be searched: ");
            int search = Convert.ToInt32(Console.ReadLine());

            bool acctFound = Array.IndexOf(acctNum, search) >= 0;

            if(acctFound == true)
            {
                int indexVal = Array.IndexOf(acctNum, search);
                Console.WriteLine("\nAccount number: {0} has a balance of: {1:c} dollars\n", acctNum[indexVal], acctBal[indexVal]);
            }
        }

        public void printData()
        {
            Console.WriteLine("{0, 27}", "Account Balances");
            Console.WriteLine("{0,15} {1,20}", "Account Number", "Account Balance");
            for(int a = 0; a < acctNum.Length; a++)
            {
                Console.WriteLine("{0,9} {1,21:c}", acctNum[a], acctBal[a]);
            }
        }
    }

    class Assignment_4B_Klein
    {
        static void Main(string[] args)
        {
            Account user = new Account();
           
            user.getData();

            user.searchData();

            user.printData();

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
