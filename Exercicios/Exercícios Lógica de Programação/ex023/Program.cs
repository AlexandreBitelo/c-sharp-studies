/*
23) Numa promoção exclusiva para o Dia da Mulher, uma loja quer dar descontos 
para todos, mas especialmente para mulheres. Faça um programa que leia nome, 
sexo e o valor das compras do cliente e calcule o preço com desconto. Sabendo 
que: - Homens ganham 5% de desconto - Mulheres ganham 13% de desconto
*/

using System;

class Program
{

    static void Main ()
    {
        double productPrice, descPrice; 
        String name;
        char sex; 

        Console.WriteLine ("-- CALCULADORA DE PROMOÇÕES --");
        
        Console.Write ("Qual seu nome: ");
        name = Console.ReadLine();

        Console.Write ("Qual seu sexo (H / M): ");
        sex = Convert.ToChar(Console.ReadLine());

        Console.Write ("Qual o valor das compras: ");
        productPrice = Convert.ToDouble(Console.ReadLine());

        if (sex == 'H')
        {
            descPrice = productPrice - (productPrice * 0.05);
            Console.WriteLine ("O valor dos produtos com 5% é {0, 0:c}", descPrice);
        }

        if (sex == 'M')
        {
            descPrice = productPrice - (productPrice * 0.13);
            Console.WriteLine ("O valor dos produtos com 13% é {0, 0:c}", descPrice);
        }
    }
}