//calc no of years , months,days
namespace AgeInDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int AgeInDays = int.Parse(Console.ReadLine());
            int noOfYears = 0;
            int noOfMonths = 0;
            int noOfDays = 0;
            while(AgeInDays >= 365)
            {
                noOfYears++;
                AgeInDays -= 365;
            }
            while (AgeInDays >= 30) { 
             noOfMonths++;
                AgeInDays -= 30;
            }
            noOfDays = AgeInDays;
            Console.WriteLine($"{noOfYears} years");
            Console.WriteLine($"{noOfMonths} months");
            Console.WriteLine($"{noOfDays} days");
        }
    }
}
