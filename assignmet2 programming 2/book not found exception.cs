using System;
using System.Collections.Generic;
using System.Text;

namespace assignmet2_programming_2
{
    class Booknotfoundexception:Exception
    {
        public Booknotfoundexception(string message): base(message) { }
    }
}
