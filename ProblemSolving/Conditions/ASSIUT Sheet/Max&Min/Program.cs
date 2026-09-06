//enter 3 numbers print the max and min
namespace Max_Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int[]arr = numbers.Split(" ").Select(int.Parse).ToArray();
            int min = arr[0];
            int max = arr[0];
            for(int i=1; i<arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max) { 
                max=arr[i];
                }
            }
            Console.WriteLine($"{min} {max}");
        }
    }
}
