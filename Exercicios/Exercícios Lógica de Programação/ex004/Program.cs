/*
4) Desenvolva um algoritmo que leia dois números inteiros e mostre o somatório 
entre eles. 
Ex: 
Digite um valor: 8 
Digite outro valor: 5 
A soma entre 8 e 5 é igual a 13.
*/

using System;

class Program
{
    public static void Main()
    {
        int number1;
        int number2;

        Console.Write("Digite um valor: ");
        number1 = int.Parse(Console.ReadLine());

        Console.Write("Digite outro valor: ");
        number2 = int.Parse(Console.ReadLine());

        Console.Write("A soma entre {0} e {1} é igual a {2}", number1, number2, (number1 + number2));
    }
}