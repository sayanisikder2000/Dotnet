using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest1_SayaniSikder
{
    internal class Asst1_Sayani
    {
        static void Main(string[] args)
        {
            int output = 0;
            Console.WriteLine("Enter the size of the Array");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Output=" + (-2));
            }
            else
            {
                Console.WriteLine($"Enter the {n} elements of the Array");
                int[] inputArr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    inputArr[i] = int.Parse(Console.ReadLine());
                }
                Array.Sort(inputArr);
                int secondMin = inputArr[0];
                int secondMax = inputArr[n - 1];
                for (int i = 1; i < inputArr.Length - 1; i++)
                {
                    if (secondMin < inputArr[i])
                    {
                        secondMin = inputArr[i];
                        break;
                    }

                }
                    for (int i = n-2; i > 0; i--)
                    {
                        if (secondMax > inputArr[i])
                        {
                            secondMin = inputArr[i];
                        break ;
                        }
                    }
                    


                output = secondMin+secondMin;
                Console.WriteLine("Output=" + output);
            }
        }
    }
}
