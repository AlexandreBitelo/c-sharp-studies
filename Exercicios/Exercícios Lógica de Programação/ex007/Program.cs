/*
7) Crie um algoritmo que leia um número real e mostre na tela o seu dobro e a 
sua terça parte. 
Ex:  
Digite um número: 3.5 
O dobro de 3.5 é 7.0 
A terça parte de 3.5 é 1.16666 
*/

using System;

class Program
{
    public static void Main()
    {
        double number;

        Console.WriteLine("Digite um número: ");
        number = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("O dobro de {0} é {1}", number, number * 2);
        Console.WriteLine("A terça parte de {0} é {1}", number, number / 3);


    }
}







