/*
11) Desenvolva uma lógica que leia os valores de A, B e C de uma equação do 
segundo grau e mostre o valor de Delta.
*/

using System; 

class Program
{
    public static void Main()
    {
        double a, b, c, delta, x1, x2;

        Console.WriteLine("-- CALCULADORA DE BHASKARA --");

        Console.Write("Qual o valor de A: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Qual o valor de B: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Qual o valor de C: ");
        c = Convert.ToDouble(Console.ReadLine());

        delta = Math.Pow(b, 2) - (4 * a * c);

        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        x2 = (-b - Math.Sqrt(delta)) / (2 * a);

        Console.Write("\n");
        Console.WriteLine("Resultados... ");
        Console.WriteLine("Valor do Delta: {0}", delta);
        Console.WriteLine("X1 : {0}", x1);
        Console.WriteLine("X2 : {0}", x2);

    }
}