namespace GCD
{
        internal class Program
        {
            static void Main(string[] args)
            {
                string numbers = Console.ReadLine();
                int a = (numbers.Split(" ").Select(int.Parse).ToArray())[0];
                int b = (numbers.Split(" ").Select(int.Parse).ToArray())[1];
                int maxDivisor = 1;
                for (int i = 1; i <= Math.Min(a, b); i++)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        maxDivisor = i;
                    }
                }
                Console.WriteLine(maxDivisor);
            }
        }
    
}
