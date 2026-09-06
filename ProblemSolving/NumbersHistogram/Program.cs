namespace NumbersHistogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int[] nums = s.Split(" ").Select(int.Parse).ToArray();
            if (nums.Length != n)
            {
                Console.WriteLine($"Wrong input. must be {n} numbers");
                return;
            }
            for(int i=0; i<nums.Length; i++)
            {
                for (int j = 0; j < nums[i]; j++) {
                    Console.Write(c);
                }
                Console.Write("\n");
            }

        }
    }
}
