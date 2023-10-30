using Exercicio3.Entities;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taxpayer> list = new List<Taxpayer>();

            Console.WriteLine("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data");
                Console.Write("Individual or company? (i/c) ");
                string option = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(option == "i")
                {
                    Console.Write("Health expenditures: ");
                    double healthExpensives = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, healthExpensives));
                } else if ( option == "c")
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, employees));
                }
            }

            Console.WriteLine();

            double sum = 0.0;
            foreach(Taxpayer taxpayer in list)
            {
                Console.WriteLine(taxpayer);
                sum += taxpayer.TaxPay();
            }

            Console.WriteLine("TOTAL TAXES: ");
            Console.Write($"$ {sum.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}