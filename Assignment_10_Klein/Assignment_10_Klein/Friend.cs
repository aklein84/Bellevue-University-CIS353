using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10_Klein
{
    class Friend
    {
        private string firstName;
        public string FIRSTNAME
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        private string lastName;
        public string LASTNAME
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        private string phoneNumber;
        public string PHONENUMBER
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

        private int month;
        public int MONTH
        {
            get
            {
                return month;
            }
            set
            {
                month = Convert.ToInt32(value);
            }
        }

        private int day;
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

        public new string ToString()
        {
            return (FIRSTNAME + ',' + LASTNAME + ',' + PHONENUMBER + ',' + MONTH + "," + DAY);
        }
    }
}
