using System;

namespace assignmet2_programming_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Book book1 = new Book("the holy bible",200);
            Book book2 = new Book("tiger by the tail",100);
            Book book3 = new Book("the girl with a dragon tatttoo",100);
            Book[] library = new Book[3] { book1, book2, book3 };
            Console.WriteLine("please enter book title");
            string book= Console.ReadLine();
            try
            {
                bool mabook = false;
                foreach (Book b in library)
                {
                    if (b.Title == book)
                    {
                        mabook = true;
                        Console.WriteLine("the price of the book " + b.Title + " is " + b.Price);
                    }
                }

                if (!mabook)
                {
                    throw new Booknotfoundexception("book does not exist in the library");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
