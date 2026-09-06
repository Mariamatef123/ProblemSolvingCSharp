namespace SumOfConsecutiveOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr= new string[n];
            int[]sumResult= new int[n];
            int a, b;
            int sum = 0;
            for(int i = 0;i<n; i++)
            {
              arr[i]=Console.ReadLine();
                a = (arr[i].Split(" ").Select(int.Parse).ToArray())[0];
                b = (arr[i].Split(" ").Select(int.Parse).ToArray())[1];
                for(int j = Math.Min(a, b)+1; j < Math.Max(a, b); j++)
                {
                    if (j % 2 != 0) {
                        sum += j;
                    }
                }
                sumResult[i] = sum;
                sum = 0;
            }
            for (int i = 0; i < n; i++) { 
            Console.WriteLine(sumResult[i]);
            }
        }
    }
}
