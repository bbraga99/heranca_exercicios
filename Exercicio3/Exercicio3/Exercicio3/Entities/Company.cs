using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3.Entities
{
    internal class Company : Taxpayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double annualIncome, int numberOfEmployees)
            :base(name,annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double TaxPay()
        {
            double payment = 0;
            if(NumberOfEmployees <= 10)
            {
                payment = AnnualIncome * 0.16;
            } else
            {
                payment = AnnualIncome * 0.14;
            }
            return payment;
        }
    }
}
