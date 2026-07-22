namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[]arr= new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
           
            for (int i = 0;i < n; i++)
            {
                int factorial = arr[i];
                for (int j = arr[i]-1;j > 0 ; j--)
                {
                    factorial *= j;
                }
                Console.WriteLine(factorial);
            }
        }
    }
}
