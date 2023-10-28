using ExercicioHeranca.Entities;
using System.Globalization;
using System;

namespace Course
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());  

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i+1} data: ");
                Console.Write("Outsourced (y/n): ");
                string? option = Console.ReadLine();
                Console.Write("Name: ");
                string? name = Console.ReadLine();   
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(option == "y")
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employee employee = new OutsourcedEmployee(name, hours, value, additionalCharge);
                    employees.Add(employee);
                } else if ( option == "n") 
                {
                    Employee employee = new Employee(name, hours, value);
                    employees.Add(employee);
                }
            }

            Console.WriteLine("PAYMENTS: ");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }


        }
    }
}