namespace PalindromeArray
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
            bool flag = true;
            for (int i = 0, j = n - 1; i <= j; i++, j--)
            {
              if(arr[i] != arr[j]) {  flag = false; break; }
            }
            Console.WriteLine(flag ? "YES" : "NO");
        }
    }
}
