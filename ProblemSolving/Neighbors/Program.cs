namespace Neighbors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];
            string[,] arr = new string[n, m];
            bool neighbors = true;
            for (int i = 0; i < n; i++)
            {
                string[] raw = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = raw[j];
                }
            }
                int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int a = ab[0] - 1;
                int b = ab[1] - 1;

            if (a == 0 && b != 0)
            {
                if (arr[(a), (b - 1)] != "x" || arr[(a), (b + 1)] != "x" ||
                    arr[(a + 1), (b - 1)] != "x" ||
                    arr[(a + 1), (b)] != "x" || arr[(a + 1), (b + 1)] != "x"
              )
                {
                    neighbors = false;
                }
            }
            else if (b == 0 && a != 0)
            {

                if (arr[(a - 1), (b)] != "x" || arr[(a - 1), (b + 1)] != "x" ||
                    arr[(a), (b + 1)] != "x" || arr[(a + 1), (b)] != "x" ||
                            arr[(a + 1), (b + 1)] != "x")
                {
                    neighbors = false;
                }

            }
            else if (a == 0 && b == 0)
            {
                if (arr[(a), (b + 1)] != "x" || arr[(a + 1), (b)] != "x" ||
                            arr[(a + 1), (b + 1)] != "x")
                {
                    neighbors = false;
                }

            }
            else if (a == n - 1 && b != m - 1)
            {
                if (arr[(a - 1), (b - 1)] != "x" || arr[(a - 1), (b)] != "x" ||
          arr[(a - 1), (b + 1)] != "x" || arr[(a), (b - 1)] != "x" ||
          arr[(a), (b + 1)] != "x"
          )
                {
                    neighbors = false;
                }
            }
            else if (b == m - 1 && a != n - 1)
            {
                if (arr[(a - 1), (b - 1)] != "x" || arr[(a - 1), (b)] != "x" ||
                    arr[(a), (b - 1)] != "x" || arr[(a + 1), (b - 1)] != "x" ||
                     arr[(a + 1), (b)] != "x"
          )
                {
                    neighbors = false;
                }
            }
            else if (a == n - 1 && b == m - 1) {
                if (arr[(a - 1), (b - 1)] != "x" || arr[(a - 1), (b)] != "x" ||
                    arr[(a), (b - 1)] != "x"
          )
                {
                    neighbors = false;
                }
            }
            else
            {
                if (arr[(a - 1), (b - 1)] != "x" || arr[(a - 1), (b)] != "x" ||
          arr[(a - 1), (b + 1)] != "x" || arr[(a), (b - 1)] != "x" ||
          arr[(a), (b + 1)] != "x" || arr[(a + 1), (b - 1)] != "x" ||
          arr[(a + 1), (b)] != "x" || arr[(a + 1), (b + 1)] != "x"
          )
                {
                    neighbors = false;
                }
            }
            
                   if (neighbors)
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }

          //  if (arr[(a - 1), (b - 1)] != "x" || arr[(a - 1), (b)] != "x" ||
          //arr[(a - 1), (b + 1)] != "x" || arr[(a), (b - 1)] != "x" ||
          //arr[(a), (b + 1)] != "x" || arr[(a + 1), (b - 1)] != "x" ||
          //arr[(a + 1), (b)] != "x" || arr[(a + 1), (b + 1)] != "x"
          //)
          //  {
          //      neighbors = false;
          //  }
          //  if (neighbors)
          //  {
          //      Console.WriteLine("YES");
          //  }
          //  else
          //  {
          //      Console.WriteLine("NO");
          //  }
        
        }
    }
}
