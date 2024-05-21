using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap2._2
{
    internal abstract class Person
    {
        private string name;
        private string address;
        public string Address { get { return address; } set { address = value; } }
        public string Name { get { return name; } set { name = value; } }   
        public Person(string name,string address) 
         {
            this.name = name;
            this.address = address;
        }
        public abstract void Display();
    }
}
