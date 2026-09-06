//Read A, B. Print floor A / B, ceil A / B, round A / B
namespace TwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers= Console.ReadLine();
            int a = int.Parse((numbers.Split(" ").ToArray())[0]);
            int b = int.Parse((numbers.Split(" ").ToArray())[1]);
            Console.WriteLine($"floor {a} / {b} = {Math.Floor(a/(double)b)}");
            Console.WriteLine($"ceil {a} / {b} = {Math.Ceiling(a / (double)b)}");
            Console.WriteLine($"round {a} / {b} = {Math.Round(a / (double)b,MidpointRounding.AwayFromZero)}");
        }
    }
}
