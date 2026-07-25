namespace CountSubArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int noofTestCases = int.Parse(Console.ReadLine()) ;
          
            int no = 0;
            int[] res=new int[noofTestCases];
            for (int k = 0; k < noofTestCases; k++)
            {
                int n = int.Parse(Console.ReadLine());
                int[] arr = Console.ReadLine()
                   .Split(' ')
                   .Select(int.Parse)
                   .ToArray();
                no = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i; j < arr.Length; j++)
                    {
                        if (arr[i] <= arr[j])
                        {
                            if (j != i && j != 0)
                            {
                                if (arr[j] >= arr[j - 1])
                                {
                                    no++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                no++;
                            }

                        }
                        else
                        {
                            break;
                        }
                    }
                }
                res[k] = no;
            }

            foreach (int i in res) { 
            Console.WriteLine(i);
            }
        }
    }
}
