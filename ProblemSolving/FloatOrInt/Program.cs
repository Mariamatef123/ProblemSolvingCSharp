namespace FloatOrInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
          float number = float.Parse(Console.ReadLine());
          Console.WriteLine(number > (int)number? $"Float {(int)number} {Math.Round((number - (int)number),3)}" : $"Int {(int)number}");
        }
    }
}
