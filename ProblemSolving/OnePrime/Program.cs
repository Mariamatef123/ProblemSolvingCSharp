namespace OnePrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
           int [] notDivisable = [2,3,4,5,6];
            bool flag = true;
            for (int i = 0; i < notDivisable.Length; i++)
            {
                if (n != notDivisable[i]) { 
                if (n % notDivisable[i] == 0 || n == 1)
                {
                    flag = false;
                    break;
                }
            }
            }
            Console.WriteLine(flag ? "YES" : "NO");
        }
    }
}
