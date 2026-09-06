namespace RangeSumQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a=ab[0];
            int b=ab[1];
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            if (arr.Length != a)
            {
                return;
            }
            string []arr2=new string[b];
            for(int i=0; i<b; i++)
            {
                arr2[i] = Console.ReadLine();
            }
            int [] arr3=new int[2];
            int sum = 0;
            int[] sumArr = new int[b];
            for (int i = 0; i < arr2.Length; i++) {
                arr3[0] = (arr2[i].Split().Select(int.Parse).ToArray())[0];
                arr3[1] = (arr2[i].Split().Select(int.Parse).ToArray())[1];
                for(int j = arr3[0] - 1; j < arr3[1]; j++)
                {
                    sum += arr[j];
                }
                sumArr[i]=sum;
                sum = 0;
            }
            for (int i = 0; i < sumArr.Length; i++) { 
                Console.WriteLine(sumArr[i]);
            }
           
        }
    }
}
