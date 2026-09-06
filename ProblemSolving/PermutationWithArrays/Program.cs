namespace PermutationWithArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] arr2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int temp1 = 0;
            int temp2 = 0;
            int temp = 0;
            for (int j = 0; j < n - 1; j++)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (arr1[i] > arr1[i + 1])
                    {
                        temp1 = arr1[i];
                        arr1[i] = arr1[i + 1];
                        arr1[i + 1] = temp1;
                    }
                    if (arr2[i] > arr2[i + 1])
                    {
                        temp2 = arr2[i];
                        arr2[i] = arr2[i + 1];
                        arr2[i + 1] = temp2;
                    }
                }
            }
            for (int i = 0; i < n ; i++)
            {
                if(arr1[i] != arr2[i])
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}
