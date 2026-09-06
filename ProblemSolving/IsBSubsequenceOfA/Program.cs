namespace IsBSubsequenceOfA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split();
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);
            int[] arr = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();
            if (arr.Length != n) {
                return;
            }

            int[] arr2 = Console.ReadLine()
              .Split(' ')
              .Select(int.Parse)
              .ToArray();
            if (arr2.Length != m)
            {
                return;
            }
            int[] result = new int[m];
            int count = 0;
            int count1 = 0;
            for (int j = 0; j < m; j++) {
                for (int k = 0; k < n; k++) {
                    if (arr2[j] == arr[k]) {
                        count++;
                        result[count1] = k;
                        count1++;
                        break;
                    }
                }
            }
            bool exists=true;
            if (count == m)
            {
                for (int j = 0; j < m-1; j++) {
                    if (result[j + 1] < result[j])
                    {
                        exists = false; break;
                    }
                }
            }
            if (exists) {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
