using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest1_SayaniSikder
{
    internal class Asst2_SayaniSikder
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your Salary: ");
            int salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of shifts:");
            int shift = int.Parse(Console.ReadLine());
            int food;
            int travel;
            int salaryLeft = salary;
            if (salary > 7000)
            {
                Console.WriteLine("Output=" + (-1));
            }
            else if (salary < 0)
            {
                Console.WriteLine("Output=" + (-2));
            }
            else if (shift < 0)
            {
                Console.WriteLine("Output=" + (-3));
            }
            else
            {
                food = (salary * 20) / 100;
                salaryLeft = salaryLeft - food;

                travel = (salary * 30) / 100;
                salaryLeft = salaryLeft - travel;

                int shiftBonus = ((salary * 2) / 100) * shift;
                salaryLeft = salaryLeft + shiftBonus;
            }

            Console.WriteLine("The savings is: " + salaryLeft);
        }
    }       
}
