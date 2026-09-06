namespace FixedPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "1999";
            string [] pass = new string[5];
            for(int i=0 ; i<pass.Length ; i++)
            {
                pass[i] = Console.ReadLine();
            }
            for (int i = 0; i < pass.Length; i++) { 
            if(pass[i] != password)
                {
                    Console.WriteLine("Wrong");
                }
                else
                {
                    Console.WriteLine("Correct");
                    break;
                }
            }

        }
    }
}
