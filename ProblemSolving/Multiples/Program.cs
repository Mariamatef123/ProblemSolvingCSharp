namespace Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int a = int.Parse((numbers.Split(" ").ToArray())[0]);
            int b= int.Parse((numbers.Split(" ").ToArray())[1]);
            if (a % b == 0 || b % a == 0) {
                Console.WriteLine("Multiples");
            }
            else
            {
                Console.WriteLine("No Multiples");
            }
        }
    }
}
