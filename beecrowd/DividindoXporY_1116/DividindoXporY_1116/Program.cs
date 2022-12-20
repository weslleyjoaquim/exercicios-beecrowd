namespace DividindoXporY_1116
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int qtdCase = int.Parse(Console.ReadLine());

            for(int i = 0;i< qtdCase;i++)
            {
                string[] vetor = Console.ReadLine().Split();
                int x = int.Parse(vetor[0]);
                int y = int.Parse(vetor[1]);
                if(y==0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double divisao = (double)x/(double)y;
                    Console.WriteLine($"{divisao:f1}");
                }
            }
        }
    }
}