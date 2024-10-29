using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch07SayaniSikder
{
   class Switch
    {
        //static void Main(string[] args)
        //{
       public static void SwitchPro() {
            int x;
            Console.WriteLine("Enter value of x: ");
            x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 0:
                    Console.WriteLine("Value of x is 0");
                    break;
                case 1:
                    Console.WriteLine("Value of x is 1");
                    break;
                case 2:
                    Console.WriteLine("Value of x is 2");
                    break;
                case 3:
                    Console.WriteLine("Value of x is 3");
                    break;
                case 4:
                    Console.WriteLine("Value of x is 4");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;

            }
        }
    }
}
