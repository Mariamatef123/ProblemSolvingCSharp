namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr= new int[n];
            for (int i = 1; i <= n; i++) { 
                if(i==1) arr[i-1] = 0;
                else if(i==2) arr[i-1] = 1;
                else
                {
                    arr[i-1] = arr[i - 2] + arr[i-3]; 
                }
            }
            Console.WriteLine(arr[n-1]);

        }
    }
}
