/*
6) Faça um programa que leia um número inteiro e mostre o seu antecessor e seu 
sucessor. 
Ex:  
Digite um número: 9 
O antecessor de 9 é 8 
O sucessor de 9 é 10 
*/

using System;

class Program
{
    public static void Main()
    {
        int number;

        Console.Write("Digite um número: ");
        number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("O antecessor de {0} é {1}", number, number - 1);
        Console.WriteLine("O sucessor de {0} é {1}", number, number + 1);
    }
}




