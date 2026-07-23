using System.Linq;

namespace SequenceOfNumbers_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> result = new List<string>();
            string s;
            string res;
            int[] arr;
            int sum;
            int count=0;
            while (true) {
                s = Console.ReadLine();
                arr = s.Split(" ").Select(int.Parse).ToArray();
                if (arr.Contains(0) || arr.Any(x=>x<0)) break;
                sum = 0;
                res = null;
                for (int i = Math.Min(arr[0], arr[1]); i <= Math.Max(arr[0], arr[1]); i++)
                {
                    if (res == null) { res = $"{i} "; }
                    else { res += $"{i} "; }
                        sum += i;
                }
                res+=$"sum ={sum}";
                result.Insert(count ,res);
                count++;
            }

            if (result != null)
            {
                foreach(string str in result)
                {
                        Console.WriteLine(str);
                }
            }
        }

    }
}
