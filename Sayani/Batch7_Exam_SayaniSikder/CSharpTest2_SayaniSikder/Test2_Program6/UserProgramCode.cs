using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Program6
{
    class UserProgramCode
    {
        public static string reshape(String input1,char input2)
        {
            string str = "";
            char[] arr = input1.ToCharArray();
            
            for(int i = 0; i < input1.Length-1; i++)
            {
                str = str + arr[i] + input2;
            }
            str =str + arr[input1.Length - 1];

           string str2 = "";
            for(int i = str.Length-1; i >= 0; i--)
            {
                str2 += str[i];
            }
            return str2;
        }
    }
}
