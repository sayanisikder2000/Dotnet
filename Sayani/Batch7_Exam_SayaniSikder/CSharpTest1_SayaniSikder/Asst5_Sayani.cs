using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest1_SayaniSikder
{
    internal class Asst5_Sayani
    {
        public static void Main(string[] args)
        
        {
            Console.WriteLine("****************welcome to My Chocolate Store********************** ");
        int dairyMilkCost = 50;
        int kitkatCost = 40;
        int munchCost = 30;
        int totalBill = 0;

        Console.WriteLine("Please choose your options");
            Console.WriteLine("For Dairy Milk Choose:1");
            Console.WriteLine("For Kitkat Choose:2");
            Console.WriteLine("For Munch Choose:3");
            int choosenOption1 = int.Parse(Console.ReadLine());

            switch (choosenOption1)
            {
                case 1:
                    totalBill = totalBill + dairyMilkCost;
                    break;
                case 2:
                    totalBill = totalBill + kitkatCost;
                    break;
                case 3:
                    totalBill = totalBill + munchCost;
                    break;
                default:
                    Console.WriteLine("Enter a valid input");
                    break;
            }
            while (true)
            {
                Console.WriteLine("You want more(y/n): ");
                char input2 = Convert.ToChar(Console.ReadLine());
                if(input2 == 'y')
                {
                    Console.WriteLine("Please choose your options");
                    Console.WriteLine("For Dairy Milk Choose:1");
                    Console.WriteLine("For Kitkat Choose:2");
                    Console.WriteLine("For Munch Choose:3");
                    int choosenOption2 = int.Parse(Console.ReadLine());

                    switch (choosenOption2)
                    {
                        case 1:
                            totalBill = totalBill + dairyMilkCost;
                            break;
                        case 2:
                            totalBill = totalBill + kitkatCost;
                            break;
                        case 3:
                            totalBill = totalBill + munchCost;
                            break;
                        default:
                            Console.WriteLine("Enter a valid input");
                            break;
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Thanks for choosing my chocolate");
            Console.WriteLine("Your total amount is: Rs:" + totalBill);
            Console.WriteLine("*********************************Payment done******************************");
        }
    }
}
