namespace HardCompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int a = int.Parse((numbers.Split(" ").ToArray())[0]);
            int b = int.Parse((numbers.Split(" ").ToArray())[1]);
            int c = int.Parse((numbers.Split(" ").ToArray())[2]);
            int d = int.Parse((numbers.Split(" ").ToArray())[3]);
            Console.WriteLine(Math.Pow(a, b) > Math.Pow(c,d) ? "YES" : "NO");
        }
    }
}
