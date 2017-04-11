using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEx2
{
    class Contributor
    {
        public string name { get; set; }
        public string cpf { get; set; }
        public double annualIncome { get; set; }
        public int dependents { get; set; }

        public double CalculateTax()
        {
            double dependentsDiscount = this.dependents * 110.00;
            double annualDiscount = 0;

            if (this.annualIncome > 130000) {
                annualDiscount = this.annualIncome * 0.15; 
            } else if (this.annualIncome > 65000) {
                annualDiscount = this.annualIncome * 0.1;
            } else if (this.annualIncome > 15000) {
                annualDiscount = this.annualIncome * 0.05;
            }

            return annualDiscount + dependentsDiscount;
        }
    }
}
