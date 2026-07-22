namespace Difference
{
    //Read A, B, C, D. Print Difference = (A _ B) - (C _ D)

    internal class Program
        {
            static void Main(string[] args)
            {
                string numbers = Console.ReadLine();
                int[] num = numbers.Split(" ").Select(int.Parse).ToArray();
                int a = num[0];
                int b = num[1];
                int c = num[2];
                int d = num[3];
            Console.WriteLine($"Difference = {(a * b) - (c * d)}");
            }

        }

    }
