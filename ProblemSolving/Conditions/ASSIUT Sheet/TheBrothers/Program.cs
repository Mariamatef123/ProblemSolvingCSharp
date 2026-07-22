//if second name equals print ARE Brothers else print not
namespace TheBrothers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string secondName1 = (name1.Split(" ").ToArray())[1];
            string name2 = Console.ReadLine();
            string secondName2 = (name2.Split(" ").ToArray())[1];
            if ((secondName1.ToLower()).Equals(secondName2.ToLower())) {
                Console.WriteLine("ARE Brothers");
            }
            else
            {
                Console.WriteLine("NOT");
            }
        }
    }
}
