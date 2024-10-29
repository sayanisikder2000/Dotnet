using System;

namespace Test2_Program1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("size: ");
           int size = Convert.ToInt32(Console.ReadLine());


            List<int> list = new List<int>();
            Console.WriteLine($"enter {size} elements");
            for (int i = 0; i < size; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                
                list.Add(input);
            }

            Console.WriteLine("Enter the number: ");
            int find = Convert.ToInt32(Console.ReadLine());


           
            if (size == 0)
            {
                Console.WriteLine("No element found");
            }
            else
            {
                List<int> list1 = UserProgramCode.GetElements(list, find);
                foreach (int p in list1)
                {
                    Console.Write(p + " ");
                }
                List<int> list2 = UserProgramCode.GetElements2(list, find);
                foreach (int k in list2)
                {
                    Console.Write(k + " ");
                }
            }

        }
    }
}