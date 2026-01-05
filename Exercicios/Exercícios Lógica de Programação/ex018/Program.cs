/*
18) Faça um programa que leia o ano de nascimento de uma pessoa, calcule a idade 
dela e depois mostre se ela pode ou não votar. 
*/

using System;

class Program
{
    static void Main (String[] args)
    {
        int bornAge, currentYear, age = 0;

        Console.Write("Em que ano você nasceu? ");
        bornAge = Convert.ToInt32(Console.ReadLine ());

        Console.Write ("Qual o ano atual? ");
        currentYear = Convert.ToInt32(Console.ReadLine());

        age = currentYear - bornAge;

        Console.WriteLine ("Sua idade é {0}", age);
    }
}