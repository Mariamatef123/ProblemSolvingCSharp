// enter 2 numbers between them operator need print the result from this expression
namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            string [] arr;
            foreach (var e in expression) {
                if (e == '+')
                {
                    arr = expression.Split('+');
                    Console.WriteLine(int.Parse(arr[0]) + int.Parse(arr[1]));
                }
                else if (e == '-')
                {
                    arr = expression.Split("-");
                    Console.WriteLine(int.Parse(arr[0]) - int.Parse(arr[1]));
                }
                else if (e == '*')
                {
                    arr = expression.Split("*");
                    Console.WriteLine(int.Parse(arr[0]) * int.Parse(arr[1]));
                }
                else if (e == '/') { 
                arr = expression.Split("/");
                    Console.WriteLine(int.Parse(arr[0]) / int.Parse(arr[1]));
                }
            }
        }
    }
}
