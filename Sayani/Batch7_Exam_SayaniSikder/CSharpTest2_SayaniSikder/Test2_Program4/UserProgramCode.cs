using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Program4
{
     class UserProgramCode
    {
        public static string FormString(string[] inputArray, int n)
        {
            string res = "";

            foreach (string str in inputArray)
            {

                foreach (char i in str)
                {
                    if (!char.IsLetterOrDigit(i))
                    {
                        return "-1";
                    }
                }

                if (n - 1 < str.Length)
                {
                    res += str[n - 1];
                }
                else
                {
                    res += "$";
                }
            }

            return res;
        }

        }
    }
