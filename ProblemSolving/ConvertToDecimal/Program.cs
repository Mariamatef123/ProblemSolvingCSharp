namespace ConvertToDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] decimals = new int[n];
            string binary;
            int[] decimalResult = new int[n];
            string ones = null;
            int sum;
            for (int i = 0; i < decimals.Length; i++) {

                sum = 0;
                decimals[i] = int.Parse(Console.ReadLine());
                binary = Convert.ToString(decimals[i], 2);
                foreach (char c in binary)
                {
                    if (c == '1')
                    {
                        sum++;
                    }
                }
                
                    for (int j = 0; j < sum; j++)
                    {
                        if (ones == null)
                        {
                            ones = $"{1}";
                        }
                        else
                        {
                            ones += $"{1}";
                        }
                    }
                    decimalResult[i] = Convert.ToInt32(ones, 2);
                    sum = 0;
                    ones = null;
                

            }
            for (int i = 0; i < decimalResult.Length; i++)
            {
                Console.WriteLine(decimalResult[i]);
            }
        }
    }
}
