// if char is small print it capital and if capital print it small
namespace Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());
            if(letter.ToString() == letter.ToString().ToLower())
            {
                Console.WriteLine(letter.ToString().ToUpper());
            }
            else
            {
                Console.WriteLine(letter.ToString().ToLower());
            }
        }
    }
}
