using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4A_Klein
{
    public class Date
    {
        protected int month;
        protected int day;
        protected int year;

        public Date()
        {
            MONTH = 1;
            DAY = 1;
            YEAR = 2000;
            Console.WriteLine("Using no-argument constructor, assigning date 1/1/2000");
        }

        public Date(int myMonth, int myDay)
        {
            MONTH = myMonth;
            DAY = myDay;
            YEAR = 2004;
            Console.WriteLine("Using 2-argument constructor, assigning year 2004");
        }

        public Date(int myMonth, int myDay, int myYear)
        {
            MONTH = myMonth;
            DAY = myDay;
            YEAR = myYear;
            Console.WriteLine("Using 3-argument constructor, for mo/da/yr");
        }

        public int MONTH
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }

        public int DAY
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }

        public int YEAR
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
    }

    class Assignment_4A_Klein
    {
        static void Main(string[] args)
        {
            // Start no argument object
            Console.WriteLine("Implementing overloaded constructors program");
            Divider();

            Date noArgs = new Date();
            Console.WriteLine("The date in this object is {0}/{1}/{2}\n", noArgs.MONTH, noArgs.DAY, noArgs.YEAR);
            Divider();
            
            // Start 2 argument object
            Console.Write("Enter a month eg: 10 for October: ");
            int myMonth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a day eg: 24: ");
            int myDay = Convert.ToInt32(Console.ReadLine());

            Date twoArgs = new Date(myMonth, myDay);
            Console.WriteLine("The date in this object is {0}/{1}/{2}\n", twoArgs.MONTH, twoArgs.DAY, twoArgs.YEAR);
            Divider();

            // Start 3 argument object
            Console.Write("Enter a month eg: 10 for October: ");
            int myMonth1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a day eg: 24: ");
            int myDay1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a year eg: 1950: ");
            int myYear1 = Convert.ToInt32(Console.ReadLine());

            Date threeArgs = new Date(myMonth1, myDay1, myYear1);
            Console.WriteLine("The date in this object is {0}/{1}/{2}\n", threeArgs.MONTH, threeArgs.DAY, threeArgs.YEAR);
            Divider();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // Method to create divider similiar to that in the example. Easier to use a method than to code each instance.
            void Divider()
            {
                for(int a = 0; a < 50; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
