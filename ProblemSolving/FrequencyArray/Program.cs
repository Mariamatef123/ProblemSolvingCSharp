namespace FrequencyArray
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
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] < 1 && arr[i] > m) {
                    return;
                }
            }
            int count = 0;
            int[] result = new int[m];
            int index = 0;
           for(int i = 1; i <= m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (i == arr[j])
                    {
                        count++;
                    }
                }
                result[index++] = count;
                count = 0;
            }
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
  
    }
}
