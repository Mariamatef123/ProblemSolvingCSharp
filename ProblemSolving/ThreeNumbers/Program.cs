namespace ThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string numbers = Console.ReadLine();
           int k =( numbers.Split(" ").Select(int.Parse).ToArray())[0];
            int s = (numbers.Split(" ").Select(int.Parse).ToArray())[1];
            int sum = 0;
            for (int x = 0; x <= s; x++) {
                for (int y = 0; y <= s; y++) { 
                    for(int z = 0; z <= s; z++)
                    {
                        if (x <= k && y <= k && z <= k)
                        {
                            if (x + y + z == s)
                            {
                                sum++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
