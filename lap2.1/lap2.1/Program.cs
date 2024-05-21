using System;

namespace lap2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee[] partTimeEmployees = //khởi tạo mảng động của PartTime
            {
                new PartTimeEmployee("Le the My", 70, 99),
                new PartTimeEmployee("Duong Khanh Linh", 30, 25),
                new PartTimeEmployee("Do Tien Dat", 40, 55),
                new PartTimeEmployee("Dao van tung", 22, 16),
                new PartTimeEmployee("Le Gia Huy", 60, 19)
            };
            FullTimeEmployee[] fullTimeEmployees = // khởi tạo mảng động của FullTime
            {
                new FullTimeEmployee("Do Tien Dat", 30),
                new FullTimeEmployee("Pham Duc Trung", 20),
                new FullTimeEmployee("Nguyen Thuy Duong", 10),
                new FullTimeEmployee("Do Tien De", 27),
                new FullTimeEmployee("Do Tien Do", 39),
                new FullTimeEmployee("Do Tien Trung", 37),
                new FullTimeEmployee("Le The My", 69),
            };

            while (true)  
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Employees with the highest salary");
                Console.WriteLine("2. Search Employees by Name");
                Console.WriteLine("3. Exit");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            FindHighestPaidEmployees(partTimeEmployees, fullTimeEmployees);
                            break;
                        case 2:
                            Console.Write("Enter employee name to search: ");
                            string name = Console.ReadLine();
                            SearchEmployeeByName(partTimeEmployees, fullTimeEmployees, name);
                            break;
                        case 3:
                            return; // Exit the program
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        static void FindHighestPaidEmployees(PartTimeEmployee[] partTimeEmployees, FullTimeEmployee[] fullTimeEmployees)
        {
            // tìm nhân viên có lương partime cao nhất 
            PartTimeEmployee highestPaidPartTimeEmployee = partTimeEmployees[0];
            foreach (var partTimeEmployee in partTimeEmployees)
            {
                if (partTimeEmployee.calculateSalary() > highestPaidPartTimeEmployee.calculateSalary())
                {
                    highestPaidPartTimeEmployee = partTimeEmployee;
                }
            }

            // tìm nhân viên full time có lương cao nhất
            FullTimeEmployee highestPaidFullTimeEmployee = fullTimeEmployees[0];
            foreach (var fullTimeEmployee in fullTimeEmployees)
            {
                if (fullTimeEmployee.calculateSalary() > highestPaidFullTimeEmployee.calculateSalary())
                {
                    highestPaidFullTimeEmployee = fullTimeEmployee;
                }
            }

            Console.WriteLine($"Highest Paid Part Time Employee:\n {highestPaidPartTimeEmployee},\n");
            Console.WriteLine($"Highest Paid Full Time Employee:\n {highestPaidFullTimeEmployee},\n");
        }


        static void SearchEmployeeByName(PartTimeEmployee[] partTimeEmployees, FullTimeEmployee[] fullTimeEmployees, string name)
        {
            bool found = false;
            foreach (var partTimeEmployee in partTimeEmployees)
            {
                if (partTimeEmployee.getName().Equals(name, StringComparison.OrdinalIgnoreCase)) // so sánh 2 sâu kí tự 
                {
                    Console.WriteLine($"Found Part Time Employee: {partTimeEmployee}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                foreach (var fullTimeEmployee in fullTimeEmployees)
                {
                    if (fullTimeEmployee.getName().Equals(name, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Found Full Time Employee: {fullTimeEmployee}");
                        found = true;
                        break;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine($"Employee with name '{name}' not found.");
            }
        }
    }
}
