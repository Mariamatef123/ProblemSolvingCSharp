namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];
            int SumOfMainDiagonal = 0;
            int SumOfSecondaryDiagonal = 0;
            for (int i = 0; i < n; i++)
            {
                string[] raw = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = int.Parse(raw[j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        SumOfMainDiagonal += arr[i, j];
                    }
                    if ((i + j) == (n - 1))
                    {
                        SumOfSecondaryDiagonal += arr[i, j];
                    }
                }
            }
            Console.WriteLine(Math.Abs(SumOfMainDiagonal-SumOfSecondaryDiagonal));
        }
    }
}
