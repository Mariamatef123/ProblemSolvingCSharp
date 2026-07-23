namespace EasyFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] fib= new int[n];
            for (int i = 1; i <= n; i++) {
                if (i == 1) { fib[i - 1] = 0; }//fib(0)=0
                else if (i == 2) { fib[i - 1] = 1; }//fib(1)=1
                else
                {
                    fib[i - 1] = fib[i - 2] +fib[i - 3];
                }
            }
            foreach (int i in fib) { 
            Console.Write($"{i} ");
            }
        }
    }
}
