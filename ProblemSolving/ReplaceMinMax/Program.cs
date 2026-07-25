namespace ReplaceMinMax
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
            int min = arr[0];
            int indexOfMin = 0;
            int max = arr[0];
            int indexOfMax = 0;
            for (int i = 1; i < arr.Length; i++) {
                if (arr[i] < min) { 
                min = arr[i];
                indexOfMin = i;
                }
                if (arr[i] > max) { 
                max = arr[i];
                indexOfMax = i;
                }
            }
            arr[indexOfMax]=min; 
            arr[indexOfMin]=max;
            foreach (int i in arr) { 
            Console.Write($"{i} ");
            }
        }
    }
}
