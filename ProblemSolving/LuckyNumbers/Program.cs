namespace LuckyNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int a = (numbers.Split(" ").Select(int.Parse).ToArray())[0];
            int b = (numbers.Split(" ").Select(int.Parse).ToArray())[1];
            bool flag = false;
            int count=0;
            for (int i = a;i <= b; i++)
            {
             
                foreach (char j in i.ToString()) {
                    if (j != '4' && j != '7') break;
                    count++;
                }
                if(count== i.ToString().Length)
                {
                    flag=true;
                    Console.Write($"{i} ");
                }
                count = 0;
            }
            if (flag == false) {
                Console.Write(-1);
            }
        }
    }
}
