namespace CrescenteDescrescente_1113
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split();
            int x = int.Parse(vetor[0]);
            int y = int.Parse(vetor[1]);

            while(x !=y)
            {
                if (x > y)
                {
                    Console.WriteLine("Decrescente");
                    vetor = Console.ReadLine().Split();
                    x = int.Parse(vetor[0]);
                    y = int.Parse(vetor[1]);
                }
                else
                {
                    Console.WriteLine("Crescente");
                    vetor = Console.ReadLine().Split();
                    x = int.Parse(vetor[0]);
                    y = int.Parse(vetor[1]);
                }
            }
        }
    }
}