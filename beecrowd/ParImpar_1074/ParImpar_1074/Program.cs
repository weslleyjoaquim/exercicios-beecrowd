namespace ParImpar_1074
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            
            for(int i = 0; i < number; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if(x>0 && x % 2 == 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if(x>0 && x%2 !=0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if(x<0 && x% 2 == 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                } else if (x == 0)
                {
                    Console.WriteLine("NULL");
                }
                else
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
            }
        }
    }
}
