namespace EvenOddPositiveNegative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string numbers = Console.ReadLine();
            int[] nums = numbers.Split(" ").Select(int.Parse).ToArray();
            if (nums.Length != n)
            {
                Console.WriteLine("Wrong input. must be 5 numbers");
                return;
            }
            int noOfEvens = 0, noOfOdd = 0, noOfPositive = 0, noOfNegative = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] % 2 == 0)
                {
                    noOfEvens++;
                }
                else
                {
                    noOfOdd++;
                }
                if (nums[i] > 0)
                {
                    noOfPositive++;
                }
                else if (nums[i] < 0)
                {
                    noOfNegative++;
                }
            }
            Console.WriteLine($"Even: {noOfEvens}");
            Console.WriteLine($"Odd: {noOfOdd}");
            Console.WriteLine($"Positive: {noOfPositive}");
            Console.WriteLine($"Negative: {noOfNegative}");
        }
    }
}
