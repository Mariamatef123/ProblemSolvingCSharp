//enter letter or digit the print ALPHA ,IS CAPITAL OR IS SMALL,IS DIGIT
namespace CapitalOrSmallOrDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            if (int.TryParse(input.ToString(),out int num)) {
                Console.WriteLine("IS DIGIT");
            }
            else
            {
                Console.WriteLine("ALPHA");
                if (input.ToString() == input.ToString().ToLower())
                {
                    Console.WriteLine("IS SMALL");
                }
                else
                {
                    Console.WriteLine("IS CAPITAL");
                }
            }
        }
    }
}
