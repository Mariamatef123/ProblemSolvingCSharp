namespace TheBrothers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1= Console.ReadLine();
            string name2= Console.ReadLine();
            string secondName1 = name1.Split(" ").ToArray()[1].ToLower();
            string secondName2 = name2.Split(" ").ToArray()[1].ToLower();
            Console.WriteLine(secondName1== secondName2 ? "ARE Brothers" : "NOT");
        }
    }
}
