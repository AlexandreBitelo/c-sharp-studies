/*
22) Escreva um programa que leia o ano de nascimento de um rapaz e mostre a sua 
situação em relação ao alistamento militar. - Se estiver antes dos 18 anos, mostre em quantos anos faltam para o 
alistamento. - Se já tiver depois dos 18 anos, mostre quantos anos já se passaram do 
alistamento. 
*/

using System;

class Program
{
    static void Main ()
    {
        int bornYear, currentYear, yearsSinceEnlistment;
        bool enlisted; 

        Console.WriteLine ("- VERIFICADOR DE ALISTAMENTO MILITAR -");

        Console.Write ("Em que ano você nasceu? ");
        bornYear = Convert.ToInt32(Console.ReadLine());

        Console.Write ("Qual é o ano atual? ");
        currentYear = Convert.ToInt32(Console.ReadLine());

        enlisted = ( currentYear - bornYear ) >= 18;

        if (enlisted)
        {
            yearsSinceEnlistment = (currentYear - bornYear) - 18;
            Console.WriteLine ("Você já passou do alistamento, foram passados {0} anos do alistamento", yearsSinceEnlistment);
        } else
        {
            yearsSinceEnlistment = 18 - (currentYear - bornYear);
            Console.WriteLine ("Você ainda não tem idade para o alistamento, ainda faltam {0} anos para o alistamento", yearsSinceEnlistment );
        }
    }
}