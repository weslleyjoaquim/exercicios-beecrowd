namespace MediaPonderada_1079
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int qtdCase = int.Parse(Console.ReadLine());

            for(int i =0;i<qtdCase;i++)
            {
                string[] vetor = Console.ReadLine().Split();
                double valorA = double.Parse(vetor[0]);
                double valorB = double.Parse(vetor[1]);
                double valorC = double.Parse(vetor[2]);
                double media = (valorA * 2 + valorB * 3 + valorC * 5)/ (2 + 3 + 5);
                Console.WriteLine($"{media:f1}");


            }
        }
    }
}