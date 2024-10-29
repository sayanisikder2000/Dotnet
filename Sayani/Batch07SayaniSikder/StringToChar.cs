using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch07SayaniSikder
{
    internal class StringToChar
    {
        public static void StrToChar()
        {
            String str = "SAYANI,SIKSER@";
            Console.WriteLine("String Elements are: ");
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " ");
            }
        }
    }
}
