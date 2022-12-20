namespace PositivoMedia_1064
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int positivos = 0;
            double soma = 0, media;

            for(int i = 0; i < 6; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number > 0)
                {
                    positivos++;
                    soma += number;
                }
            }
            media = soma / positivos;
            Console.WriteLine($"{positivos} valores positivos");
            Console.WriteLine($"{media:F1}");
        }
    }
}
