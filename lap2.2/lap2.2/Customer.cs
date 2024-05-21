using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap2._2
{
    internal class Customer : Person
    {
        private int balance;
        public int Balance {  get { return balance; } set { balance = value; } }
        public Customer(string name,string address,int balance )
            :base(name,address){
            Balance = balance;
        }
        public override void Display()
        {
            Console.WriteLine();
        }
    }
}
