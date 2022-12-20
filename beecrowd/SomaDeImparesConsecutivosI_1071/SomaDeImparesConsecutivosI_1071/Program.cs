namespace SomaDeImparesConsecutivosI_1071
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Leia 2 valores inteiros X e Y. A seguir, calcule e mostre a soma dos números impares entre eles.

            int valorX = int.Parse(Console.ReadLine());
            int valorY = int.Parse(Console.ReadLine());
            int valorMaior,valorMenor, somaValores=0;
            
            if (valorX > valorY) {
                valorMaior = valorX;
                valorMenor = valorY;

            }
            else
            {
                valorMaior = valorY;
                valorMenor = valorX;
            }
            //somar o valor menor +1 para tornar número positivo      
            for(int i = valorMenor+1; i < valorMaior; i++)
            {
                if(i%2 != 0)
                {
                    somaValores+=i;
                }                
            }
            Console.WriteLine(somaValores);               
            
        }

    }
}