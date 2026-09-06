namespace SearchInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split();
            int n=int.Parse(nm[0]);
            int m=int.Parse(nm[1]);
            int[,]arr=new int[n,m];
            for(int i=0; i<n; i++)
            {
                string[] raw = Console.ReadLine().Split();
                for(int j=0; j<m; j++)
                {
                    arr[i,j] = int.Parse(raw[j]);
                }
            }
            int input=int.Parse(Console.ReadLine());
            bool exists =false;
            for(int i=0; i<n; i++)
            {
                for(int j=0; j < m; j++)
                {
                    if(arr[i,j] == input)
                    {
                        exists = true;
                    }
                }
            }
            if (exists)
            {
                Console.WriteLine("Will Not Take Number");
            }
            else
            {
              Console.WriteLine("Will Take Number");
            }
        }
    }
}
