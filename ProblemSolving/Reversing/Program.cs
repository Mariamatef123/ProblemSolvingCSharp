namespace Reversing
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
            int temp = 0;
            for (int i = 0 ,j = n-1; i <= j; i++,j--)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;          
            }
            foreach (int i in arr) { 
            Console.Write($"{i} ");
            }
        }
    }
}
