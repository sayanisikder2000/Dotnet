using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest1_SayaniSikder
{
    internal class Asst4_Sayani
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter the size of the Array");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter the {n} elements of the Array");
            int[] inputArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                inputArr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the searching number:");
            int input3 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (input3 == inputArr[i])
                {
                    count++;
                }
            }
            Console.WriteLine("Output=" + count);
        }
    }
}
