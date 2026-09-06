// print the num in which interval [0,25] (25,50] (50,75] (75, 100]
namespace Interval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            if(num >= 0 && num <= 25)
            {
                Console.WriteLine("Interval [0,25]");
            }
            else if (num > 25 && num <= 50)
            {
                Console.WriteLine("Interval (25,50]");
            }
            else if (num > 50 && num <= 75)
            {
                Console.WriteLine("Interval (50,75]");
            }
            else if (num > 75 && num <= 100)
            {
                Console.WriteLine("Interval (75,100]");
            }
            else
            {
                Console.WriteLine("Out of Intervals");
            }
        }
    }
}
