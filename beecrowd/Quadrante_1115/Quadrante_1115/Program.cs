namespace Quadrante_1115
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split();
            int x = int.Parse(vetor[0]);
            int y = int.Parse(vetor[1]);

            while(x !=0 && y != 0)
            {
                if(x>0 && y>0)
                {
                    Console.WriteLine("primeiro");
                    vetor = Console.ReadLine().Split();
                    x = int.Parse(vetor[0]);
                    y = int.Parse(vetor[1]);
                }
                else if(x<0 && y > 0)
                {
                    Console.WriteLine("segundo");
                    vetor = Console.ReadLine().Split();
                    x = int.Parse(vetor[0]);
                    y = int.Parse(vetor[1]);
                }
                else if(x<0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                    vetor = Console.ReadLine().Split();
                    x = int.Parse(vetor[0]);
                    y = int.Parse(vetor[1]);
                }
                else
                {
                    Console.WriteLine("quarto");
                    vetor = Console.ReadLine().Split();
                    x = int.Parse(vetor[0]);
                    y = int.Parse(vetor[1]);
                }
                
            }
        }
    }
}