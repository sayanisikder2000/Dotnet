using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
    class InsurancePlan:Insurance
        {
        public void OtherInsuranPlan()
        {
            Console.WriteLine("This are the other plans.........");
        }
        public override void InsuranceDetails(int insuranceNumber, int insuranceAmount, int totalDays)
        {
            Console.WriteLine("Enter your name");
            String Name = Console.ReadLine();
            Console.WriteLine("Enter your Card Number");
            insuranceNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Name + " your insurance amount is: " + insuranceAmount + " and your plans valid for only " + totalDays + " Days");

        }
    }
}
