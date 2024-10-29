using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Program5
{
    internal class UserProgramCode
    {
        public static string getData(String input)
        {
            string op = "";

            foreach (char s in input)
            {

                if (!op.Contains(s))
                {
                    op += s;

                }
            }
            return op;
        }
    }
}
