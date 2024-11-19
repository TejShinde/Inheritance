using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class MainInheritance
    {
        static void Main(string[] args)
        {
            // option1
            Date d1 = new Date(1, "Jan", 2025);

            Employee emp1 = new Employee("Amol", 45600, d1);
            emp1.CalculateSalary();
            Console.WriteLine(emp1);

            // option2

            Employee emp2 = new Employee("Raj", 34000, new Date(1, "Nov", 2024));
            emp2.CalculateSalary();
            Console.WriteLine(emp2);


            SalesManager sm1 = new SalesManager("Rohan", 34000, d1, 5000, 6700);
            sm1.CalculateSalary();
            Console.WriteLine(sm1);// want to print sm1 object information -> ToString()

            Employee emp3 = new SalesManager("Suraj", 33000, d1, 4500, 5500);
            emp3.CalculateSalary(); // compile time , it call Employee method
            // late binding , runtime polymorphism / dynamic binding
            Console.WriteLine(emp3);

            CEO ceo1 = new CEO("seema", 150000, d1, 50000, "BMW 7 Series");
            ceo1.CalculateSalary();
            Console.WriteLine(ceo1); // Calls CEO.ToString()

            // Display total employee count
            Console.WriteLine($"Total Employees: {Employee.EmpCount()}");

        }

    }
}
