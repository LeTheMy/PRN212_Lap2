using System;

namespace lap2._1
{
    public class PartTimeEmployee : Employee
    {
        private int workingHours;

        public int WorkingHours { get { return workingHours; } set { workingHours = value; } } //chuyển từ private sang public gọi hàm set and get 

        public PartTimeEmployee(string name, int paymentPerHour, int workingHours)
            : base(name, paymentPerHour)
        {
            WorkingHours = workingHours; //gán giá trị cho WorkingHour 
        }

        public override int calculateSalary()
        {
            return workingHours * PaymentPerHour; //override từ lớp IEmooyee

        }

        public override string getName()
        {
            return Name;
        }

        public override string ToString()//khởi tạo tostring 
        {
            return $"Name: {getName()}, Payment Per Hour: {PaymentPerHour}, Working Hours: {WorkingHours}, Salary: {calculateSalary()}";
        }
    }
}
