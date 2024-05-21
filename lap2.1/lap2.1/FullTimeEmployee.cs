using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap2._1
{
    internal class FullTimeEmployee : Employee  // kế thừa từ Employee
    {
        
        public FullTimeEmployee(string name, int paymentPerHour) : base(name, paymentPerHour) {
        
        }
        public override int calculateSalary()
        {
            return PaymentPerHour * 8; 
        }
        public override string getName()
        {
            return Name;
        }
        public override string ToString()
        {
            return $"Name: {Name}  salary:{calculateSalary()}";
        }
    }
}
