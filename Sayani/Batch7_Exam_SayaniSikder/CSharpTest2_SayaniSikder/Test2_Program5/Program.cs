namespace Test2_Program5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
           // char[] c = input.ToCharArray();

           String result = UserProgramCode.getData(input);
            Console.WriteLine(result);
        }
    }
}
