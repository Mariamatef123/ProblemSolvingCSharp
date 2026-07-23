namespace LowestNumber
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
            int index = 1;
            int lowest = arr[0];
            for (int i = 1; i < n; i++)
            {
                if( arr[i] < lowest)
                {
                    lowest= arr[i];
                    index = i+1;
                }
            }
            Console.WriteLine($"{lowest} {index}");

        }
    }
}
