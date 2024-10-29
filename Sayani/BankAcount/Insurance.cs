using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
   abstract class Insurance
    {
        protected int insuranceAmount;
        int totalDays;
        public abstract void InsuranceDetails(int insuranceNumber, int insuranceAmount, int totalDays);
     

    }
}
