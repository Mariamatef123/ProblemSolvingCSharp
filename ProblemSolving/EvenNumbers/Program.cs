namespace EvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                if (i % 2 != 0) continue;
                Console.WriteLine(i);
            }
            if (n <= 1)
            {
                Console.WriteLine(-1);
            }
        }
    }
}
