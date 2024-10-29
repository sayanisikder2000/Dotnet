namespace Test2_Program3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());
            if (input1 < 100 || input1 > 220)
            {
                Console.WriteLine("Invalid Caliber");
            }
            else if (input2 < 0 || input2 > 20)
            {
                Console.WriteLine("Invalid years");
            }
            else
            {
                double d = UserProgramCode.findMileage(input1, input2);
                Console.WriteLine("The mileage of the bike is "+ d);
            }
        }
    }
}
