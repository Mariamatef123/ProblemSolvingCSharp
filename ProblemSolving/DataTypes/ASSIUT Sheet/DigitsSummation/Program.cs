//Read N, M. Print sum of last digit of N + last digit of M
namespace DigitsSummation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int[] arr = numbers.Split(" ").Select(int.Parse).ToArray();
            int n = Convert.ToInt32((arr[0].ToString())[arr[0].ToString().Length - 1].ToString());
            int m = Convert.ToInt32((arr[1].ToString())[arr[1].ToString().Length - 1].ToString());
            Console.WriteLine(n + m);
        }
    }
}
