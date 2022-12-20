namespace NumerosPositivos_1060
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            int positivo = 0;

            for(int i = 0; i <6;i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number > 0)
                {
                    positivo++;
                }
            }
            Console.WriteLine($"{positivo} valores positivos");
        
        }
    }
}

