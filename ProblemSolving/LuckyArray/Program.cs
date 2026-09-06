namespace LuckyArray
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
            int sum = 0;
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++) {
                if (arr[i] < min) { 
                min = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i]== min) {
                sum++;
                }

            }
            Console.WriteLine(sum % 2 != 0 ? "Lucky" : "UnLucky"); 
        }
    }
}
