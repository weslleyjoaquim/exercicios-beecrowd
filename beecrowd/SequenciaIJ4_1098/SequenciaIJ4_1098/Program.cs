namespace SequenciaIJ3_1097
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for(double i = 0; i <= 2; i += 0.2)
            {
                for(double j = i + 1; j <= i + 3; j++)
                {
                    if(i==0 || i == 2)
                    {
                        Console.WriteLine($"I={i} J={j}");
                    }
                    else
                    {
                        Console.WriteLine($"I={Math.Round(i,1)} J={Math.Round(j,1)}");
                    }
                }
            }
        }
    }
}