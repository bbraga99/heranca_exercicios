using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3.Entities
{
    internal class Individual : Taxpayer
    {
        public double HealthExpenses { get; set; }

        public Individual()
        {
            
        }

        public Individual(string name, double annualIncome, double healthExpenses)
            : base(name,annualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double TaxPay()
        {
            double discount = 0.0;
            if(HealthExpenses > 0)
            {
                discount = HealthExpenses * 0.50;
            }

            double payment = 0.0;
            if(AnnualIncome < 20000.00)
            {
                payment = (AnnualIncome * 0.15) - discount;
            } else if(AnnualIncome >= 20000.00)
            {
                payment = (AnnualIncome * 0.25) - discount;
            }
            return payment;
        }
    }
}
