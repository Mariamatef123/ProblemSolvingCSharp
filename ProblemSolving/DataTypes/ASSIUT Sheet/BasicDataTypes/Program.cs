//Read int, long, char, float, double in one line. Print them each in new line
namespace BasicDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String mix = Console.ReadLine();
            string[] arr = mix.Split(" ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
