namespace Test2_Program6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String input1 = Console.ReadLine();
            char input2 =  Convert.ToChar(Console.ReadLine());

            String output = UserProgramCode.reshape(input1, input2);
            Console.WriteLine(output);
        }
    }
}
