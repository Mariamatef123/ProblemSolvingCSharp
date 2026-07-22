namespace TwoIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Intervals = Console.ReadLine();
            decimal l1 = decimal.Parse((Intervals.Split(" ").ToArray())[0]);
            decimal r1 = decimal.Parse((Intervals.Split(" ").ToArray())[1]);
            decimal l2 = decimal.Parse((Intervals.Split(" ").ToArray())[2]);
            decimal r2 = decimal.Parse((Intervals.Split(" ").ToArray())[3]);
            if (l1 <= l2)
            {
                if (r2 >= r1 && r1>l2)
                {
                    Console.WriteLine($"{l2} {r1}");
                    return;
                }
                else if (r1 > r2 && r2 > l2)
                {
                    Console.WriteLine($"{l2} {r2}");
                    return;
                }
            }
            else if(l1 > l2)
            { 
                if (r2 >= r1 && r1 > l1) 
                {
                    Console.WriteLine($"{l1} {r1}");
                    return;
                }
                else if (r1 > r2 && r2 > l1)
                {
                    Console.WriteLine($"{l1} {r2}");
                    return;
                }
               
            }
            
                Console.WriteLine(-1);
            
        }
    }
}
