using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap2._1
{
   public abstract class Employee : IEmployee
    {
        private String name;
        private int paymentPerHour ;
        public string Name { get { return name; } set { name = value; } }
        public int PaymentPerHour { get {  return paymentPerHour; } set {  paymentPerHour = value; } }
        public Employee(string name, int paymentPerHour) {
            Name = name;
         PaymentPerHour = paymentPerHour;
        }
        public abstract int calculateSalary();
        public abstract string getName();
        public override string ToString()
        {
            return $"Name:{Name} PaymentPerHour:{PaymentPerHour}";
        }

    }
}
