using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch07SayaniSikder
{
    class StringArray
    {
        public static void StringArr()
        {
            String[] arr = new String[10] { "JAVA", "C++","JAVA","C++","JAVA","CSHARP","CSHARP","JAVA", "C++", "JAVA" };
            //Console.WriteLine($"Enter {arr.Length} String Values");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Console.ReadLine();
            //}
            Console.WriteLine("Array Elements are");
            foreach(String x in arr)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();
            Array.Sort(arr);

            int count = 1;
            int temp = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (i <= arr.Length && (i + 1)< arr.Length)
                {
                    if (String.Equals(arr[i], arr[i + 1]))
                    {
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"{arr[i]} comes {count} times");
                        temp++;
                        count = 1;
                    }
                }
                else
                {
                    Console.WriteLine($"{arr[i]} comes {count} times");
                    temp++;
                }

            }
            Console.WriteLine(temp + " number of reapeted elements are present");
    }
    }
}
