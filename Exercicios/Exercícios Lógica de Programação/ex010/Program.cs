/*
10) Faça um algoritmo que leia a largura e altura de uma parede, calcule e 
mostre a área a ser pintada e a quantidade de tinta necessária para o serviço, 
sabendo que cada litro de tinta pinta uma área de 2metros quadrados. 
*/

using System; 

class Program
{
    public static void Main()
    {
        double high, width, paintedArea;

        Console.WriteLine("-- CALCULADORA DE TINTA --");

        Console.Write("LARGURA: ");
        width = Convert.ToInt32(Console.ReadLine());

        Console.Write("ALTURA: ");
        high = Convert.ToInt32(Console.ReadLine());

        paintedArea = (high * width) / 2;

        Console.WriteLine("Para pintar a parede será necessário {0} litros de tinta", paintedArea);
    }
}