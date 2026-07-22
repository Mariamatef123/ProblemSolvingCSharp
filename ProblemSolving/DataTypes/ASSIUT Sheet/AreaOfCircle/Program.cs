//Read R. Print Area = 3.141592653 _ R _ R. Output 9 digits after decimal
namespace AreaOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.141592653;
            double r = double.Parse(Console.ReadLine());
            double area = pi * r * r;
            Console.WriteLine(Math.Round(area,9));
        }
    }
}
