namespace Replacement
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
                if (arr[i] > 0)
                {
                    arr[i] = 1;
                }
                else if (arr[i] < 0)
                {
                    arr[i] = 2;
                }
            }
            foreach(int i in arr)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
