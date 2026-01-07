/*
21) Faça um algoritmo que leia um determinado ano e mostre se ele é ou não 
BISSEXTO.
*/

using System;

class Program
{
    static void Main()
    {
        int yearToVerify = 0;
        bool leapYear = false; 

        Console.WriteLine ("-- VERIFICADOR DE ANO BISSEXTO --");

        Console.Write ("Ano para verificar se é bissexto: ");
        yearToVerify = Convert.ToInt32(Console.ReadLine());
        
        leapYear = (yearToVerify % 4 == 0 ) && (yearToVerify % 100 != 0) || (yearToVerify % 400 == 0); 

        Console.WriteLine ("--------------------VERIFICANDO--------------------------");

        if (leapYear)
        {
            Console.WriteLine ("O ano {0} é um ano Bissexto", yearToVerify);
        } else
        {
            Console.WriteLine ("O ano {0} NÃO é um ano bissexto", yearToVerify);
        }

    }
}