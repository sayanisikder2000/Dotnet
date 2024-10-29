namespace BankAcount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank obj1 = new Bank();
            Bank obj2 = new Bank(10000);
            Bank obj3 = new Bank(obj2);


            obj1.calculateAge(26092024);
            int interest1 =  obj1.Interest(10000);
            Console.WriteLine("Interest="+interest1);


            obj1.DebitCard("Sayani");
            obj1.CreditCard("Sayani", 100000);
            obj1.NewInsurance("Sayani");


            obj1.CalculateTotalBalance(10000, 5000);
            obj1.getCustomerDetails("Sayani");


            InsurancePlan obj4 = new InsurancePlan();
            obj4.OtherInsuranPlan();
            obj4.InsuranceDetails(5645, 1000, 365);

        }
    }
}
