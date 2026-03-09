using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_FirstSession
{
    internal class Athoer
    {
        public string Name { get; set; }
        public int ID { get; set; }
        
        public virtual void Tostring()
        {
            Console.WriteLine($"Name: {Name}, ID: {ID}");
        }
    }
}
