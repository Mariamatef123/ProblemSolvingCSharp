//Read N. Print 1 + 2 + ... + N
namespace SummationFrom1ToN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++) { 
            sum+= i;
            }
            Console.WriteLine(sum);
        }
    }
}
