using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Program1
{
    class UserProgramCode
    {
        public static List<int> GetElements(List<int> list1, int find)
        {
            if (list1.Count == 0)
            {
                list1.Add(-1);
                return list1;
            }
            else
            {
                foreach (int n in list1)
                {
                    if (n > find)
                    {
                        list1.Remove(n);
                    }
                }
                list1.Sort();
                list1.Reverse();
                return list1;
            }
        }
        public static List<int> GetElements2(List<int> list2, int find)
        {
            if (list2.Count == 0)
            {
                list2.Add(-1);
                return list2;
            }
            else
            {
                foreach (int n in list2)
                {
                    if (n < find)
                    {
                        list2.Remove(n);
                    }
                }
                list2.Sort();
                return list2;
            }
        }
    }
}
