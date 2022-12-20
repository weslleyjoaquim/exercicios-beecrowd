namespace Grenais_1131
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            int grenais = 0;
            int vitoriaInter = 0;
            int vitoriaGremio = 0;
            int empate = 0;

            while (true)
            {
                string[] gols = Console.ReadLine().Split();
                int inter = int.Parse(gols[0]);
                int gremio = int.Parse(gols[1]);
                grenais++;
                if (inter > gremio)
                {
                    vitoriaInter++;
                }else if (gremio > inter)
                {
                    vitoriaGremio++;
                }else if (inter == gremio)
                {
                    empate++;
                }
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                int novoGrenal = int.Parse(Console.ReadLine());
                if (novoGrenal == 1)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }


            Console.WriteLine($"{grenais} grenais");
            Console.WriteLine($"Inter:{vitoriaInter}");
            Console.WriteLine($"Gremio:{vitoriaGremio}");
            Console.WriteLine($"Empates:{empate}");

            //Verificar quem teve mais vitorias nos Grenais ou se houve empates no número de vitórias
            if (vitoriaInter > vitoriaGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if(vitoriaGremio>vitoriaInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }


        }
    }
}