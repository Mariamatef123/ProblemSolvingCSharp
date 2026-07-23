namespace PrimesFrom1ToN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 2 || n > Math.Pow(10, 3)) return;
            int[] notDivisable = [2, 3, 4, 5, 6];
            int count = 0;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < notDivisable.Length; j++)
                {
                    if (i != notDivisable[j] && i!=1)
                    {
                        if (i % notDivisable[j] != 0)
                        {
                            count++;
                        }
                    }
                }
                if (notDivisable.Contains(i))
                {
                    if (count == (notDivisable.Length) - 1)
                    {
                        Console.Write(i);
                        Console.Write("\t");
                    }
                }
                else
                {
                    if (count == (notDivisable.Length))
                    {
                        Console.Write(i);
                        Console.Write("\t");
                    }
                }
           count=0;
            }
        }
    }
}