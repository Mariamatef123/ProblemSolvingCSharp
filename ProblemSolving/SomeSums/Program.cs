namespace SomeSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string numbers = Console.ReadLine();
           int n = (numbers.Split(" ").Select(int.Parse).ToArray())[0];
           int a = (numbers.Split(" ").Select(int.Parse).ToArray())[1];
           int b = (numbers.Split(" ").Select(int.Parse).ToArray())[2];
           
            int sum = 0;
            int someSums = 0;
            for (int i = 1; i <= n; i++) { 
            foreach (char c in i.ToString())
                {
                    sum += int.Parse(c.ToString());
                }
                if (sum>=a && sum <= b)
                {
                    someSums += i;
                }
                sum = 0;
            }
            Console.WriteLine(someSums);
        }
    }
}
