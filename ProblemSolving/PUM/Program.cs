namespace PUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n*4; i++) {
                if (i % 4 == 0) { Console.Write("PUM\n"); }
                else { Console.Write($"{i} "); }
            }
        }
    }
}
