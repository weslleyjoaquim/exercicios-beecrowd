namespace Experiencias_1094
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int repeticao = int.Parse(Console.ReadLine());
            int rato = 0, sapo = 0, coelho = 0, totalCobaias;

            
            

            for(int i = 0; i < repeticao; i++)
            {
                String[] vetor = Console.ReadLine().Split();
                int quantiaCobaia = int.Parse(vetor[0]);
                char tipoCobaia = char.Parse(vetor[1]);
                if(tipoCobaia== 'R')
                {
                    rato += quantiaCobaia;
                }else if (tipoCobaia == 'S')
                {
                    sapo+= quantiaCobaia;
                }
                else
                {
                    coelho+= quantiaCobaia;
                }
            }
            totalCobaias = (rato + sapo + coelho);
            double percentRato = (((double)rato / (double)totalCobaias)*100);
            double percentSapo = (((double)sapo / (double)totalCobaias)*100);
            double percentCoelho = (((double)coelho / (double)totalCobaias)*100);
            Console.WriteLine($"Total: {totalCobaias} cobaias");
            Console.WriteLine($"Total de coelhos: {coelho}");
            Console.WriteLine($"Total de ratos: {rato}");
            Console.WriteLine($"Total de sapos: {sapo}");
            Console.WriteLine($"Percentual de coelhos: {percentCoelho:f2} %");
            Console.WriteLine($"Percentual de ratos: {percentRato:f2} %");
            Console.WriteLine($"Percentual de sapos: {percentSapo:f2} %");
        }
    }
}