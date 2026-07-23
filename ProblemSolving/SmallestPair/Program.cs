namespace SmallestPair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int noOfTestCases = int.Parse(Console.ReadLine());
            int sum=0;
            int smallest;
            int[] result=new int[noOfTestCases];
            for (int k = 0; k < noOfTestCases; k++)
            {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
             sum= arr[0] + arr[1]+2-1;
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (i < j || i != j)
                        {
                            smallest = arr[i] + arr[j] + (j + 1) - (i + 1);
                            if (smallest < sum)
                            {
                                sum = smallest;
                            }
                        }
                    }
                }
                result[k] = sum;
            }
            foreach(int i in result)
            {

                Console.WriteLine(i);
            }
        }
    }
}
