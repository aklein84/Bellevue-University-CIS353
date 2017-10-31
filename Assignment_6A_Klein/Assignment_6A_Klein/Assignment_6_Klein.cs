using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6A_Klein
{
    class BookException : Exception
    {
        public void InvalidRatio(string bookTitle, double bookPrice, int bookPages)
        {
            Console.WriteLine("For {0}, ratio is invalid.\n...Price is {1:c} for {2} pages", bookTitle, bookPrice, bookPages);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void NotANumber(string bookTitle, double bookPrice)
        {
            Console.WriteLine("For {0}, an invalid price was entered.", bookTitle, bookPrice);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    class Book 
    {
        const double pageRate = .10;

        private string bookTitle;
        public string TITLE
        {
            get
            {
                return bookTitle;
            }
            set
            {
                bookTitle = value;
            }

        }

        private string bookAuthor;
        public string AUTHOR
        {
            get
            {
                return bookAuthor;
            }
            set
            {
                bookAuthor = value;
            }
        }

        private double bookPrice;
        public double PRICE
        {
            get
            {
                return bookPrice;
            }
            set
            {
                bookPrice = value;                                
            }
        }

        private int bookPages;
        public int PAGES
        {
            get
            {
                return bookPages;
            }
            set
            {
                bookPages = value;
            }
        }

        public Book()
        {
            Console.Write("\nEnter title: ");
            TITLE = Console.ReadLine();

            Console.Write("Enter author: ");
            AUTHOR = Console.ReadLine();

            Console.Write("Enter price: ");
            PRICE = double.Parse(Console.ReadLine());

            Console.Write("Enter pages: ");
            PAGES = int.Parse(Console.ReadLine());
                        
            try
            {               
                if(PRICE > pageRate * PAGES)
                {
                    throw new BookException();
                }
            }
            catch (BookException err)
            {
                err.InvalidRatio(TITLE, PRICE, PAGES);
            }
        }

        public void printit(string bTitle, string bAuthor, double bPrice, int bPages)
        {
            Console.WriteLine("{0} by {1} price {2:c} {3} pages", bTitle, bAuthor, bPrice, bPages);
        }
    }

    class Assignment_6_Klein
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();       
            Book myBook2 = new Book();
            Book myBook3 = new Book();
            Book myBook4 = new Book();
            

            myBook.printit(myBook.TITLE, myBook.AUTHOR, myBook.PRICE, myBook.PAGES);
            myBook2.printit(myBook2.TITLE, myBook2.AUTHOR, myBook2.PRICE, myBook2.PAGES);
            myBook3.printit(myBook3.TITLE, myBook3.AUTHOR, myBook3.PRICE, myBook3.PAGES);
            myBook4.printit(myBook4.TITLE, myBook4.AUTHOR, myBook4.PRICE, myBook4.PAGES);
            

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
