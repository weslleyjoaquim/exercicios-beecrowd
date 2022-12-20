namespace ParesEntreCincoNumeros_1065
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            int pares = 0;

            for (int i = 0; i < 5; i++)
            {
                int numeros = int.Parse(Console.ReadLine());

                if (numeros% 2 == 0)
                {
                    pares++;
                }
            }
            Console.WriteLine($"{pares} valores pares");

        }
    }
}
