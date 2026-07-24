using System.Net.NetworkInformation;

namespace MaxSubArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int noOfTestCases = int.Parse(Console.ReadLine());
            int sum = 0;
            int[][] resultOfAllTestCases = new int[noOfTestCases][];
            for (int m = 0; m < noOfTestCases; m++)
            {
                sum = 0;
                int n = int.Parse(Console.ReadLine());
                int[] arr = Console.ReadLine()
                   .Split(' ')
                   .Select(int.Parse)
                   .ToArray();
                for (int j = 0; j <= n; j++) { sum += j; }
                int[][] result = new int[sum][];
                int[] res = new int[sum];
                int count = 0;
                int count1 = n;
                int i = 0;
                int index;
                int minus = 0;
                while (i < sum)
                {

                    index = 0;
                    for (int k = 0; k < count1; k++)
                    {
                        result[i] = new int[count + 1];
                        for (int j = 0; j <= count; j++)
                        {
                            result[i][j] = arr[index];
                            index++;
                        }
                        i++;
                        index -= minus;
                    }
                    minus++;
                    count++;
                    count1--;
                }
                int max;
                for (int j = 0; j < sum; j++)
                {
                    max = result[j][0];
                    for (int k = 0; k < result[j].Length; k++)
                    {
                        if (result[j][k] > max) { max = result[j][k]; }
                    }
                    res[j] = max;
                }
                    resultOfAllTestCases[m] = new int[sum];
                resultOfAllTestCases[m] = res;
            }
            for (int i = 0; i < noOfTestCases; i++) {
                for (int j = 0; j < resultOfAllTestCases[i].Length; j++) {
                    Console.Write($"{resultOfAllTestCases[i][j]} ");
                }
                Console.WriteLine("\n");
            }
           
        }
    }
}
