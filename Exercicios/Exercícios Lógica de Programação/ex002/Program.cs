/*
2) Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boas
vindas para ela: 
Ex: 
Qual é o seu nome? João da Silva 
Olá João da Silva, é um prazer te conhecer!
*/

using System;

class Program
{
    public static void Main()
    {
        string name;

        Console.Write("Qual é o seu nome? ");
        name = Console.ReadLine();

        Console.Write("Olá {0}, é um prazer te conhecer", name);
    }
}