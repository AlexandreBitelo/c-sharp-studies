/*
20) Desenvolva um programa que leia um número inteiro e mostre se ele é PAR ou 
ÍMPAR. 
*/

using System; 

class Program
{
    static void Main ()
    {
        double number = 0;
        int pairOrOdd;

        Console.WriteLine ("-- VERIFICADOR DE VALORES IMPARES E PARES --");

        Console.Write ("Digite um valor: ");
        number = Convert.ToDouble(Console.ReadLine());

        pairOrOdd = Convert.ToInt32(number % 2);

        if (pairOrOdd == 0)
        {
            Console.WriteLine ("O número {0} é Par", number);
        } else
        {
            Console.WriteLine ("O número {0} é Impar", number); 
        }

    }
}