namespace PositionInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < n; i++)
            {
                if(arr[i] <= 10)
                {
                    Console.WriteLine($"A[{i}] = {arr[i]}");
                }
            }
        }
    }
}
