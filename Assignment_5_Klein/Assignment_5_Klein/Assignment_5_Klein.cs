using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_Klein
{
    class Book
    {
        protected string bookTitle;
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

        protected string bookAuthor;
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

        private string bookCategory;
        public string CATEGORY
        {
            get
            {
                return bookCategory;
            }
            set
            {
                bookCategory = value;
            }
        }

        private string catProcess;
        public string SAYING
        {
            get
            {
                return catProcess;
            }
            set
            {
                catProcess = value;
            }
        }

        public void getData()
        {
            Console.WriteLine("\nYou will enter data for a {0} book indicating the {1}.", bookCategory, catProcess);

            Console.Write("\nEnter the book title: ");
            TITLE = Console.ReadLine();

            Console.Write("\nEnter book author: ");
            AUTHOR = Console.ReadLine();
        }

        public void FictionBook(string readingLevel)
        {
            Console.Write("\nThe book you entered is {0} by {1} and the reading level is {2}.\n", bookTitle, bookAuthor, readingLevel);
        }

        public void NonFictionBook(string pageNum)
        {
            Console.Write("\nThe book you entered is {0} by {1} with {2} pages.\n", bookTitle, bookAuthor, pageNum);
        }
    }

    class Fiction : Book
    {
        private string readingLevel;
        public string LEVEL
            {
                get
                {
                    return readingLevel;
                }
                set
                {
                    readingLevel = value;
                }
            }

        public Fiction()
        {
            CATEGORY = "fiction";
            SAYING = "reading level";
            getData();

            Console.Write("\nEnter the reading level: ");
            readingLevel = Console.ReadLine();

            FictionBook(readingLevel);
        }
    }

    class NonFiction : Book
    {
        private string pageNum;
        public string PAGES
            {
                get
                {
                    return pageNum;
                }
                set
                {
                    pageNum = value;
                }
            }

        public NonFiction()
        {
            CATEGORY = "non-fiction";
            SAYING = "number of pages";
            getData();

            Console.Write("\nEnter the number of pages: ");
            pageNum = Console.ReadLine();

            NonFictionBook(pageNum);
        }
    }

    class Assignment_5_Klein
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.Write("Enter f for Fiction or n for Non-Fiction: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "f":
                    case "F":
                        {
                            loop = false;
                            Fiction myBook = new Fiction();
                            break;
                        }
                    case "n":
                    case "N":
                        {
                            loop = false;
                            NonFiction myBook = new NonFiction();
                            break;
                        }
                    default:
                        Console.WriteLine("\nYou entered an incorrect option\n");
                        break;
                }
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
