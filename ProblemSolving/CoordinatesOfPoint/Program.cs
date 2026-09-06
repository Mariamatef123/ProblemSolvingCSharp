//.print Q1,Q2,Q3,Q4 according to the quarter in which the point belongs to
//print  Origem if point is at the origin
//print Eixo X if point over x axis
// print Eixo Y if point over y axis

namespace CoordinatesOfPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string point = Console.ReadLine();
            decimal x = decimal.Parse((point.Split(" ").ToArray())[0]);
            decimal y = decimal.Parse((point.Split(" ").ToArray())[1]);
            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (y > 0 && x < 0)
            {
                Console.WriteLine("Q2");
            }
            else if (y < 0 && x < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            
        }
    }
}
