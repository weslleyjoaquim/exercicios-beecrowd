namespace VariasNotasComValidacao_1118
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int totalNotas = 0;
            double soma = 0;
            

            while (true)
            {
                double notas = double.Parse(Console.ReadLine());
                if (notas >= 0 && notas <= 10)
                {
                    soma += notas;
                    totalNotas++;
                    if (totalNotas == 2)
                    {
                        Console.WriteLine($"media = {(soma/2):f2}");
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        int repeteCalculo = int.Parse(Console.ReadLine());
                        if (repeteCalculo == 1)
                        {
                            soma = 0;
                            totalNotas = 0;
                            continue ;
                        }
                        else if(repeteCalculo==2)
                        {
                            break;
                        }
                        
                    }
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
                
            }
        }
    }
}