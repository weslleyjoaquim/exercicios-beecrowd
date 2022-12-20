namespace MaiorPosicao_1080
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Leia 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.

            int maiorValor = 0;
            int posicao = 0;

            for(int i=1;i<=100;i++)
            {
                int valor = int.Parse(Console.ReadLine());
                if(valor>maiorValor)
                {
                    maiorValor = valor;
                    posicao = i;
                }
            }
            Console.WriteLine(maiorValor);
            Console.WriteLine(posicao);
        }
    }
}