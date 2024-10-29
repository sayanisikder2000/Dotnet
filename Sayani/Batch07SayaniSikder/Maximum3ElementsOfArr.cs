using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch07SayaniSikder
{
    internal class Maximum3ElementsOfArr
    {
        public static void Maximum3ElementsOfArr1()
        {
            int[] arr = new int[7] { 100, 24, 31, 42, 78, 10, 45 };
            //Array.Sort(arr);
            //for (int i = arr.Length - 1; i >= arr.Length-3; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1;j<arr.Length;j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];    
                        arr[j] = temp;
                    }
                }
            }
            foreach (int x in arr)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();
            Console.Write("Maximum 3 elements are: ");
            for(int i = 0;i < 3; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}