/*
26) Escreva um algoritmo que leia dois números inteiros e compare-os, mostrando 
na tela uma das mensagens abaixo: - O primeiro valor é o maior - O segundo valor é o maior - Não existe valor maior, os dois são iguais 
*/

using System; 

class Program
{
    static void Main ()
    {
        double number1 = 0, number2 = 0;

        Console.WriteLine ("-- COMPARADOR DE VALOR --");

        Console.Write ("Digite um número: ");
        number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write ("Digite outro número: ");
        number2 = Convert.ToDouble(Console.ReadLine ());

        Console.WriteLine ("Verificando........");

        if ( number1 == number2 )
        {
            Console.WriteLine ("Os números são iguais");
        }
        else if ( number1 > number2 )
        {
            Console.WriteLine ("O primeiro número é maior que o segundo número");
        }
        else if ( number1 < number2 )
        {
            Console.WriteLine ("O segundo número é maior que o primeiro número");
        }
        else
        {
            Console.WriteLine ("---- Não foi possível verificar os valores ----");
        }

    }
}