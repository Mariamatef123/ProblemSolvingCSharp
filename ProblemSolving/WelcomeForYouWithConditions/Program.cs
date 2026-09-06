namespace WelcomeForYouWithConditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string numbers = Console.ReadLine();
            int a = numbers.Split(" ").Select(int.Parse).ToArray()[0];
            int b = numbers.Split(" ").Select(int.Parse).ToArray()[1];
            Console.WriteLine(a >= b ? "Yes" : "No");
        }
    }
}
