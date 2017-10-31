using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Klein
{
    class PhoneCall
    {
        public void getCallLength()
        {
            Console.Write("Please enter length (in minutes) of phone call: "); // Asking for user input
            int callMinutes = Convert.ToInt32(Console.ReadLine()); // Reading user input and converting string to integer

            double callCost = calcCallCosts(callMinutes); // Calling method to return the total cost of the phone call. Method requires one parameter
            printIt(callCost, callMinutes); // Calling method to display statement of duration and cost of the call. Method requires two parameters
        }

        public double calcCallCosts(int minsUsed) // Method to calculate costs of phone call.
        {
            const double cost = .10; // cost is set as a contant as this was the requirement of the assignment.
            return (minsUsed * cost); // Calculates total cost of phone call. 

        }

        public void printIt(double callCost, int duration) // Method to print duration and total cost of phone call. 
        {
            Console.WriteLine("Current phone call lasting {0} minutes will cost {1:C}.\n", duration, callCost);
        }
    }

    class Assignment_1_Klein
    {
        static void Main(string[] args)
        {
            PhoneCall getCallInfo = new PhoneCall(); // Initializing class

            for(int x=0; x < 3; x++) // Loop 3 times asking for user input
            {
                getCallInfo.getCallLength(); // Calling class method
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(); // Wait for user to press key in order to exit
        }
    }
}
