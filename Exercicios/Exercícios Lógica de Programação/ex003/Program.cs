/*
3) Crie um programa que leia o nome e o salário de um funcionário, mostrando no 
final uma mensagem. 
Ex: 
Nome do Funcionário: Maria do Carmo 
Salário: 1850,45 
O funcionário Maria do Carmo tem um salário de R$1850,45 em Junho.
*/

using System;

class Program
{
    public static void Main()
    {
        string name;
        double wage;

        Console.Write("Qual o nome do funcionário? ");
        name = Console.ReadLine();

        Console.Write("Qual o salário? ");
        wage = double.Parse(Console.ReadLine());

        Console.WriteLine("--------INFORMAÇÕES--------");
        Console.WriteLine("Nome do funcionário: {0}", name);
        Console.WriteLine("Salário: {0,0:c}", wage);
        Console.WriteLine("---------------------------");

        Console.WriteLine("O funcionário {0} tem um salário de {1,0:c} em Junho", name, wage); 

    }
}