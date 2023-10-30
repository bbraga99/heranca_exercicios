using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio3.Entities
{
    abstract class Taxpayer
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Taxpayer()
        {
        }

        protected Taxpayer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double TaxPay();

        public override string ToString()
        {
            return $"{Name}: ${TaxPay().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
