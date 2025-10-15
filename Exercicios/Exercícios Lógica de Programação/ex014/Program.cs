/*
14) A locadora de carros precisa da sua ajuda para cobrar seus serviços. Escreva 
um programa que pergunte a quantidade de Km percorridos por um carro alugado e a 
quantidade de dias pelos quais ele foi alugado. Calcule o preço total a pagar, 
sabendo que o carro custa R$90 por dia e R$0,20 por Km rodado. 
*/

using System;

class Program
{
    public static void Main()
    {
        double distanceCovered, totalCost;
        int daysUsedByCar;

        Console.WriteLine("-- CALCULO DE DESPESAS DE CARROS --");

        Console.Write("Quantos Quilometros foram percorridos: ");
        distanceCovered = Convert.ToDouble(Console.ReadLine());

        Console.Write("Quantos dias foi usado o carro: ");
        daysUsedByCar = Convert.ToInt32(Console.ReadLine());

        totalCost = (daysUsedByCar * 90) + (distanceCovered * 0.20);

        Console.WriteLine("\n-------NOTA DE CUSTO-------");
        Console.WriteLine("Custo Total: {0}", totalCost);

    }
}