namespace ValidacaoDeNota_1117
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = 0;
            double soma = 0;

            while(true)
            {
                double nota = double.Parse(Console.ReadLine());

                if(nota>=0 && nota <= 10)
                {
                    count++;
                    soma+=nota;
                    if (count == 2)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }

            Console.WriteLine($"media = {(soma/2):f2}");
        }

    }
}