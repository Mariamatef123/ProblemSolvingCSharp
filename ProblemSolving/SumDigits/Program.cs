namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] arr = int.Parse(Console.ReadLine()).ToString().ToCharArray();
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                sum += Convert.ToInt32(arr[i].ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
