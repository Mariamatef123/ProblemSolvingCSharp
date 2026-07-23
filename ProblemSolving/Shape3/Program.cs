namespace Shape3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int col = n * 2 - 1;
            string[,] arr = new string[n, n * 2 - 1];
            string[,] arr2 = new string[n, n * 2 - 1];
            int x;
            int y;
            for (int i = 0,m=n-1; i < n && m>=0; i++,m--)
            {
                x = col - i - n;
                y = col - (n - i);
                for (int k = x; k <= y; k++)
                {
                    arr[i, k]  = "*";
                    arr2[m, k] = "*";
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n * 2 - 1; j++)
                {
                    if (arr[i, j] == null) { arr[i, j] = " "; }
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n * 2 - 1; j++)
                {
                    if (arr2[i, j] == null) { arr2[i, j] = " "; }
                    Console.Write(arr2[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

}
