// print the number sorted with new lines then blank line and the numbers as you read (without sorting)
namespace SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            decimal[] arr = numbers.Split(" ").Select(decimal.Parse).ToArray();

            decimal[] arr2 =new decimal[arr.Length];
            for(int i=0;i<arr.Length;i++)
            {
                arr2[i] = arr[i];
            }
            decimal temp = arr[0];
            for (int j = 0; j < arr.Length; j++) { 
            for (int i = 0; i < arr.Length-1; i++) {
               
                 if (arr[i] > arr[i+1])
                    {
                    temp = arr[i];
                    arr[i] = arr[i+1];
                    arr[i+1] = temp;
                    }
                }
            }
            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine(arr[j]);
            }
            Console.WriteLine("\n");
            for (int j = 0; j < arr2.Length; j++) { 
            Console.WriteLine(arr2[j]);
            }
        }
    }
}
