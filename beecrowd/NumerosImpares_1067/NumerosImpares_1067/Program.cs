namespace NumerosImpares_1067
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            if(numero>1 && numero <= 1000)
            {
                for (int i = 0; i <= numero; i++)
                {
                    if(i%2 !=0)
                    {
                        Console.WriteLine(i);
                        
                    }
                }
            }
        }
    }
}