using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Program2
{
    class UserProgramCode
    {
        public static String NegativeString(String input)
        {
            String[] str = input.Split(' ');
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == "is" || str[i] == "iS" || str[i] == "Is" || str[i] == "IS")
                {
                    str[i] = "is not";
                }
            }
            String temp = "";
            foreach (String s in str)
            {
                temp += s + " ";
            }
            return temp;
                
        }
               
        
    }
}
