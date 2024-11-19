using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class CEO : Employee
    {
        private double stockOptions;
        private string companyCar;

        public CEO(string nm, double bs, Date date, double stockOptions, string companyCar)
            : base(nm, bs, date)  
        {
            this.stockOptions = stockOptions;
            this.companyCar = companyCar;
        }

        
        public override void CalculateSalary()
        {
            hra = basic * 0.50;  // Different hra for CEO
            da = basic * 0.30;
            pf = basic * 0.10;
            gross = (basic + hra + da + stockOptions) - pf;  // Including stock options in salary
        }

        
        public override string ToString()
        {
            return $"CEO Details: Id = {id}, Name = {name}, Gross Salary = {gross}, Stock Options = {stockOptions}, Company Car = {companyCar}, Joining Date = {date.DisplayDate()}";
        }
    }
}
