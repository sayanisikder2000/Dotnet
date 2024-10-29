namespace CollectionExample
{


    class UserProgramCode
    {
        public static int sumOfDigits(string[] input1)
        {
            int count = 0;

            return 1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //example 4
            int size = int.Parse(Console.ReadLine());
            String[] input1 = new String[size];
            for (int i = 0; i < input1.Length; i++) 
            {
                input1[i] = Console.ReadLine();
            }
            UserProgramCode.sumOfDigits(input1);
        }
    }
}
