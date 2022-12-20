namespace SequenciaIJ_1096
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = 0;
            int x = 1;
            int y = 7;

            for(int i = 0;i< 15; i++)
            {
                count++;
                Console.WriteLine($"I={x} J={y--}");
                if (count % 3 == 0)
                {
                    x += 2;
                    y = 7;
                }
            }
        }
    }
}