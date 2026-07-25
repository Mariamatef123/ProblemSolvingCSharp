namespace MirrorArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];
            int[,] arr = new int[n, m];

            for (int i = 0; i < m; i++)
            {
                string[] raw = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = int.Parse(raw[j]);
                }
            }
            int temp = 0;
            for (int k = 0; k < n; k++) { 
            for (int i = 0, j = m - 1; i <= j; i++, j--) {
                temp = arr[k,i];
                    arr[k,i] = arr[k,j];
                    arr[k,j] = temp;
            }
            }
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
        }

    }
}
