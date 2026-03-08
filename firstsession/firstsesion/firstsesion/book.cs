using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstsesion
{
    internal class book
    {
        public string name { get; set; }
        public int price { get; set; }
        public string des { get; set; }

       
        public book(string Name, int Price, string Des)
        {
            name = Name;
            price = Price;
            des = Des;
        }

    }
}
