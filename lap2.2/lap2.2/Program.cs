using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lap2._2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Customer[] customers =
            {
            new Customer("Le The My","Ha Noi",25),
            new Customer("Do Tien Dat", "Dan Phuong", 21),
            new Customer("Le The Dat", "Hai Phong", 60),
            new Customer("Le The Linh", "Nam Dinh", 82),
            new Customer("Le The Trung", "Phu Quoc", 99),
             new Customer("Le The Duong","Ho Chi Minh",102),

            };
            Employee[] employees =
            {
                new Employee("Le Thi Linh","Tho Tang",40),
                new Employee("Le Thi Thuy","Tho Tang",43),
                new Employee("Le Xuan Tu","Tho Tang",80),
                new Employee("Le Gia Huy","Tho Tang",46),
                new Employee("Le Viet Hung","Vinh Phuc",50),
                new Employee("Le Tien Dat","Tho Tang",40),
                new Employee("Nguyen xuan Dung","Tho Tang",99),
            };
            Console.WriteLine("Input your choice");
            Console.WriteLine("1  Employees with the highest salaries and customers with the smallest balances ");
            Console.WriteLine("2 Find the Emphoyees by name ");
            Console.WriteLine("3 Exit");
            int minBanlance = customers[0].Balance;
            int chose;
            int maxSalary = 0;
            if (int.TryParse(Console.ReadLine(), out chose))
            {
                if (chose == 1 || chose == 2)
                {
                    switch (chose)
                    {
                        case 1:
                            {
                                for (int i = 1; i < customers.Length; i++)
                                {
                                    if (minBanlance < customers[i].Balance)
                                    {
                                        minBanlance = customers[i].Balance;
                                    }
                                }

                                foreach (var sa in employees)
                                {
                                    if (sa.Salary > maxSalary)
                                    {
                                        maxSalary = sa.Salary;
                                    }
                                }
                                Console.WriteLine($"The Customer with the samllest account is {minBanlance}");
                                Console.WriteLine($"The employee with the hightest salary is {maxSalary}");
                                break;
                            }


                        case 2:
                            {
                                String name;
                                Console.WriteLine("pls Input your name you want find:");
                                name = Console.ReadLine();
                                bool found = false;
                                foreach (var sa in employees)
                                {
                                    if (name.Equals(sa.Name))
                                    {
                                        Console.WriteLine(sa.Salary);
                                        found = true;
                                        break;
                                    }
                                }
                                if (!found)
                                {
                                    Console.WriteLine($"Employee{name} not found");
                                }
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Exiting program");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                            }




                    }
                }
                else
                {
                    Console.WriteLine("NotinValiu input. Pls enter a number again");
                }





            }
            Console.ReadLine();
        }
    }
          
}

