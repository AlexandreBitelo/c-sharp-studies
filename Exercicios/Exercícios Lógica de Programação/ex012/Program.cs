/*
12) Crie um programa que leia o preço de um produto, calcule e mostre o seu 
PREÇO PROMOCIONAL, com 5% de desconto. 
*/

using System; 

class Program
{
    public static void Main()
    {
        double cost, costWithDiscount; 
    
        Console.WriteLine("-- CALCULADORA DE PREÇO PROMOCIONAL --");

        Console.Write("Insira o valor do produto: ");
        cost = Convert.ToDouble(Console.ReadLine());

        costWithDiscount = cost - (cost * 0.05);

        Console.WriteLine("O preço do produto com 5% de desconto é {0,0:c}", costWithDiscount); 
    }
}