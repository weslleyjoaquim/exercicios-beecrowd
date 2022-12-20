namespace SeisNumerosImapres_1070
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Leia um valor inteiro X. Em seguida apresente os 6 valores ímpares consecutivos a partir de X,
            //um valor por linha, inclusive o X ser for o caso.

            int number = int.Parse(Console.ReadLine());
            int repeticao = 0;

            while (true)
            {
                if(number % 2 != 0)
                {
                    Console.WriteLine(number);
                    number++;
                    repeticao++;
                    if (repeticao == 6)
                    {
                        break;
                    }
                }
                else
                {
                    number++;                    
                }
            }

        }
    }
}