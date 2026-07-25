namespace CheckCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int a=numbers[0];
            int b=numbers[1];
            string s = Console.ReadLine();
            if (s.ToString().Length != (a+b+1))
            {
                return;
            }
            int index = 0;
            bool flag = false;
            foreach (char c in s) { 
                index++;
            if(c == '-')
                {
                    if (index == (a + 1))
                    {
                        Console.WriteLine("Yes");
                    }
                    else {
                        Console.WriteLine("No");
                    }
                    flag = true;
                    return;
                }
            }
            if (!flag) {
                Console.WriteLine("No");
            }
        }
    }
}
