/*
9) Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$) 
e mostre quantos dólares ela pode comprar. Considere US$1,00 = R$3,45. 
*/

using System; 

class Program
{
    public static void Main()
    {
        double balance;

        Console.Write("Quando dinheiro você possui em sua carteira? ");
        balance = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Você pode comprar {0} dólares", balance/3.45);
    }
}