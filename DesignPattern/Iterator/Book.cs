using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class Book
    {
        private string name;
        public Book(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
    }
}
