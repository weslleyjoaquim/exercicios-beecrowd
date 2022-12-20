namespace ParesImparesPositivosNegativos_1066
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int pares = 0;
            int negativo = 0;
            int impares = 0;
            int positivo = 0;

            for(int i = 0; i<5; i++) 
            {
                int numero = int.Parse(Console.ReadLine());
                if(numero%2 == 0 )
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
                if (numero > 0)
                {
                    positivo++;
                }
                else if(numero<0)
                {
                    negativo++;
                }
            
            }

            Console.WriteLine($"{pares} valor(es) par(es)");
            Console.WriteLine($"{impares} valor(es) impar(es)");
            Console.WriteLine($"{positivo} valor(es) positivo(s)");
            Console.WriteLine($"{negativo} valor(es) negativo(s)");
        }
    }
}
