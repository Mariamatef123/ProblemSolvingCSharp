namespace TheLast2Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int num1 = int.Parse((numbers.Split(" ").ToArray())[0]);
            int num2 = int.Parse((numbers.Split(" ").ToArray())[1]);
            int num3 = int.Parse((numbers.Split(" ").ToArray())[2]);
            int num4 = int.Parse((numbers.Split(" ").ToArray())[3]);
            int multiplication = num1 * num2 * num3 * num4;
            Console.WriteLine($"{multiplication.ToString()[multiplication.ToString().Length-2]}{multiplication.ToString()[multiplication.ToString().Length - 1]}");
        }
    }
}
