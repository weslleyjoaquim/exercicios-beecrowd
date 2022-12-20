using System;

namespace SomaDeImparesConsecutivosII_1099
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Leia um valor inteiro N que é a quantidade de casos de teste que vem a seguir.Cada caso de teste consiste de dois inteiros X e Y.
            //Você deve apresentar a soma de todos os ímpares existentes entre X e Y.

            int repeticao = int.Parse(Console.ReadLine());
                        
            int i = 0;
            while (i<repeticao) {
                
                string[] valores = Console.ReadLine().Split(' ');
                int valorX = int.Parse(valores[0]);
                int valorY = int.Parse(valores[1]);
                int valorMaior, valorMenor, somaValores = 0;

                if (valorX > valorY)
                {
                    valorMaior = valorX;
                    valorMenor = valorY;

                }
                else
                {
                    valorMaior = valorY;
                    valorMenor = valorX;
                }
                for (int j = valorMenor + 1; j < valorMaior; j++)
                {
                    if (j % 2 != 0)
                    {
                        somaValores += j;
                    }
                }
                i++;
                Console.WriteLine(somaValores);
            }
                
            
        }

    }
}