using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Date
    {
            private int day;
            private string month;
            private int year;

            public Date(int day, string month, int year)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }

            public string DisplayDate()
            {
                return $"{day} {month} {year}";
            }
        }
}
