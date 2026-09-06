namespace Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            for (int i = 0; i < n; i++) { 
                arr[i] =Console.ReadLine(); 
            }
            string s;
            for (int i = 0; i < n; i++) {
                s = arr[i];
                for (int j = s.Length-1; j >=0; j--) {
                Console.Write($"{s.ToArray()[j]} ");
                }
                Console.Write($"\n");
            }
        }
    }
}
