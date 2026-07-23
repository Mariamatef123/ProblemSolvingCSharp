namespace Shape2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            int col = n * 2 - 1;
            string[,] arr=new string[n,n*2-1];
            int x;
            int y;
            for (int i = 0; i < n; i++)
            {
                x = col-i-n;
                y = col-(n-i) ;
                  for(int k = x; k <= y; k++)
                    {
                        arr[i,k] += "*";
                    }
            }
            for (int i = 0; i < n; i++) { 
            for(int j = 0;j < n*2-1; j++)
                {
                    if(arr[i,j] == null) { arr[i, j] = " "; }
                    Console.Write(arr[i,j]);
                }
            Console.WriteLine();
            }
        }
    }

}
