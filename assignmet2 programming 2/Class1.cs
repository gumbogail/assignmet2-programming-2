using System;
using System.Collections.Generic;
using System.Text;

namespace assignmet2_programming_2
{
    class Book

    {
        public string Title { get; set; }
        public double Price { get; set; }
        public Book(string title, double price)
      
         {
            this.Title = title;
            this.Price = price;

         }
    }
}
