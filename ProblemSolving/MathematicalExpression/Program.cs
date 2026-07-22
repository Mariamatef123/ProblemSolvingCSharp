namespace MathematicalExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            string[] arr;
            string[] arr2;
            foreach (var e in expression)
            {
                if (e == '+')
                {
                    arr = expression.Split('+');
                    arr2 = arr[1].Split("=");
                    Console.WriteLine(((int.Parse(arr[0]) + int.Parse(arr2[0]))== int.Parse(arr2[1]))?"Yes": (int.Parse(arr[0]) + int.Parse(arr2[0])));
                }
                else if (e == '-')
                {
                    arr = expression.Split("-");
                    arr2 = arr[1].Split("=");
                    Console.WriteLine(((int.Parse(arr[0]) - int.Parse(arr2[0])) == int.Parse(arr2[1]))?"Yes": (int.Parse(arr[0]) - int.Parse(arr2[0])));
                }
                else if (e == '*')
                {
                    arr = expression.Split("*");
                    arr2 = arr[1].Split("=");
                    Console.WriteLine(((int.Parse(arr[0]) * int.Parse(arr2[0])) == int.Parse(arr2[1])) ? "Yes" : (int.Parse(arr[0]) * int.Parse(arr2[0])));
                }
                else if (e == '/')
                {
                    arr = expression.Split("/");
                    arr2 = arr[1].Split("=");
                    Console.WriteLine(((int.Parse(arr[0]) + int.Parse(arr2[0])) == int.Parse(arr2[1])) ? "Yes" : (int.Parse(arr[0]) + int.Parse(arr2[0])));
                }
            }
        }
    }
}
