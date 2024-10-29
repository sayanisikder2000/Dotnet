namespace Test2_Program4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            string[] inputArray = new string[k];

            for (int i = 0; i < k; i++)
            {
                inputArray[i] = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine());

            string result = UserProgramCode.FormString(inputArray, n);

            Console.WriteLine(result);
        }
    }
}

