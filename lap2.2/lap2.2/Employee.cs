using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap2._2
{
    internal class Employee : Person
    {
        private int salary;
        public int Salary { get { return salary; } set { Salary = salary; } }
        public Employee(string name, string address, int salary) : base(name, address)
        {
            this.salary = salary;
        }
        public override void Display()
        {
            Console.WriteLine($"Name: {Name} Address: {Address} Salary:{Salary}");
        }
    }
}
