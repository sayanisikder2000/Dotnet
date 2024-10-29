namespace CollectionExample2
{
    class EmplyeeDesignation
    {
        public static String[] getEmployees(String[] input1,String input2)
        {
           List<String> list = new List<string> ();
            for (int i = 0; i < input1.Length; i++)
            {
                if (input2.ToLower() == input1[i].ToLower())
                {
                    list.Add(input1[i - 1]);
                }
            }
            return list.ToArray ();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()); 
            String[] str = new String[size]; 
            for(int i = 0;i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }
            String find = Console.ReadLine();
            String[] op = EmplyeeDesignation.getEmployees(str, find);
            int count = 0;

            foreach(String s in op)
            {
                foreach (Char c in s)
                {
                    if (!char.IsLetterOrDigit(c))
                    {
                        count++;
                    }
                }
            }

            foreach (char item in find)
            {
                if (!char.IsLetterOrDigit(item) && !char.IsWhiteSpace(item))
                {
                    count++;
                }
            }

            if(count != 0)
            {
                Console.WriteLine("invalid input");
            }
            else if(op.Length == str.Length / 2)
            {
                Console.WriteLine("All emps belong to same {0} designating", find);
            }else if(op.Length == 0)
            {
                Console.WriteLine("No emps for {0} designation", find);
            }
            else
            {
             foreach(String item in op)
                {
                    Console.WriteLine(item);   
                }
            }

        }
    }
}
