//Read X, Y. Print X + Y =, X _ Y =, X - Y = 
namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int [] num = numbers.Split(" ").Select(int.Parse).ToArray();
            int x = num[0];
            int y = num[1];
            Console.WriteLine($"{x} + {y} = {(x + y)}");
            Console.WriteLine($"{x} * {y} = {(x * y)}");
            Console.WriteLine($"{x} - {y} = {(x - y)}");

        }

    }
}
