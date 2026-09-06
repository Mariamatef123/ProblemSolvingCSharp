namespace MinimizeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            bool even = true;
            int noOfOperations = 0;
            while (even)
            {
                foreach (int i in arr)
                {
                    if (i % 2 != 0)
                    {
                     even = false;
                      break;
                    }
                }
                if (even)
                {
                    noOfOperations++;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = arr[i] / 2;
                        if (arr[i] % 2 != 0)
                        {
                            even = false;
                            break;
                        }
                    }
                
                }
            
            }
            Console.WriteLine(noOfOperations);
        }
    }
}
