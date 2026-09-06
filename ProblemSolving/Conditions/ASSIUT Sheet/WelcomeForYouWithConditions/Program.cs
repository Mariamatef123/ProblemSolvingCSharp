// if a> b print yes else print not
namespace WelcomeForYouWithConditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int a = int.Parse((numbers.Split(" ").ToArray())[0]);
            int b = int.Parse((numbers.Split(" ").ToArray())[1]);
            if (a >= b)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
