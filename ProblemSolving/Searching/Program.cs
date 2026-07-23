namespace Searching
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
            int input = int.Parse(Console.ReadLine());
            int index = -1;
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i] == input)
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine(index);

        }
    }
}
