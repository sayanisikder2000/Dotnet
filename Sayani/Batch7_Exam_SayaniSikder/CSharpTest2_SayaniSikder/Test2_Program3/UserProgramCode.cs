using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Program3
{
    class UserProgramCode
    {
        public static double findMileage(int input1,int input2)
        {
            if (input1 >= 100 && input2 <= 125)
            {
                double mileage = 75;
                if (input2 >= 1 && input2 <= 2)
                {
                    return (mileage - ((mileage * 10) / 100));

                }else if(input2 > 2 && input2 <= 4)
                {
                    return (mileage - ((mileage * 15) / 100));
                }
                else if (input2 > 4 )
                {
                    return (mileage - ((mileage * 20) / 100));
                }
                else
                {
                    return mileage;
                }
            }
            else if (input1 >= 126 && input2 <= 135)
            {
                double mileage = 70;
                if (input2 >= 1 && input2 <= 2)
                {
                    return (mileage - ((mileage * 10) / 100));

                }
                else if (input2 > 2 && input2 <= 4)
                {
                    return (mileage - ((mileage * 15) / 100));
                }
                else if (input2 > 4)
                {
                    return (mileage - ((mileage * 20) / 100));
                }
                else
                {
                    return mileage;
                }

            } else if (input1 >= 136 && input2 <= 150)
            {
                double mileage = 60;
                if (input2 >= 1 && input2 <= 2)
                {
                    return (mileage - ((mileage * 10) / 100));

                }
                else if (input2 > 2 && input2 <= 4)
                {
                    return (mileage - ((mileage * 15) / 100));
                }
                else if (input2 > 4)
                {
                    return (mileage - ((mileage * 20) / 100));
                }
                else
                {
                    return mileage;
                }

            } else if(input1 >= 151 && input2 <= 200)
            {
                double mileage = 50;
                if (input2 >= 1 && input2 <= 2)
                {
                    return (mileage - ((mileage * 10) / 100));

                }
                else if (input2 > 2 && input2 <= 4)
                {
                    return (mileage - ((mileage * 15) / 100));
                }
                else if (input2 > 4)
                {
                    return (mileage - ((mileage * 20) / 100));
                }
                else
                {
                    return mileage;
                }

            }
            else if(input1 >= 201 && input2 <= 220)
            {
                double mileage = 35;
                if (input2 >= 1 && input2 <= 2)
                {
                    return (mileage - ((mileage * 10) / 100));

                }
                else if (input2 > 2 && input2 <= 4)
                {
                    return (mileage - ((mileage * 15) / 100));
                }
                else if (input2 > 4)
                {
                    return (mileage - ((mileage * 20) / 100));
                }
                else
                {
                    return mileage;
                }
            }
            else
            {
                return 1;
            }
        }

    }
}
