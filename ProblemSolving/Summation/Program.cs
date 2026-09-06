namespace Summation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int [] arr= Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            for (int i = 0; i < n; i++) {
                
                sum += arr[i];
            }
            Console.WriteLine(Math.Abs(sum));
        }
    }
}
