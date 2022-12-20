namespace TiposDeTriangulos_1045
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] linha = Console.ReadLine().Split();

            double a = double.Parse(linha[0]);
            double b = double.Parse(linha[1]);
            double c = double.Parse(linha[2]);

            if (c > b && c > a)
            {
                double aux = c;
                c = a;
                a = aux;
            } else if (b > a && b > c)
            {
                double aux = b;
                b = a;
                a = aux;
            }
            if (c > b)
            {
                double aux = c;
                c = b;
                b = aux;
            }
            //Só realizar agora as condições dos triangulos

            if (a >= (b + c))
            {
                Console.WriteLine("NAO FORMA TRINAGULO");
                return;
            } else if (a * b == b * b + c * c)
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            } else if (a * b > b * b + c * c)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            } else if (a * b < b * b + c * c)
            {
                Console.WriteLine("TRIANGULO ACTUSANGULO");
            }

            if (a==b && b == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }else if (a == b || a == c || b == c)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
            {

            }
        }
    }
}