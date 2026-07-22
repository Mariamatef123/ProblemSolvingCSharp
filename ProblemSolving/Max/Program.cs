namespace Max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string numbers = Console.ReadLine();
            int[] nums = numbers.Split(" ").Select(int.Parse).ToArray();
            if (nums.Length != n) {
                Console.WriteLine("Wrong input. must be 5 numbers");
                return;
            }
            int max = nums[0];
            foreach(var num in nums)
            {
                if (num > max)
                {
                    max= num;
                }
            }
            Console.WriteLine(max);
        }
    }
}
