namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string n = Console.ReadLine();
            string[] arr = new string[n.Length];
            
           for(int x=0,y=arr.Length-1; x <= y ; x++, y--)
            {
                arr[y] = n[x].ToString();
                arr[x] = n[y].ToString();
            }

            string n2 = string.Join("", arr);

            Console.WriteLine(int.Parse(n2));
            Console.WriteLine(n == n2 ? "YES" : "NO");

        }
    }
}
