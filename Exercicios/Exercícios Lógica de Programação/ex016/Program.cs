/*
16) [DESAFIO] Escreva um programa para calcular a redução do tempo de vida de um 
fumante. Pergunte a quantidade de cigarros fumados por dias e quantos anos ele 
já fumou. Considere que um fumante perde 10 min de vida a cada cigarro. Calcule 
quantos dias de vida um fumante perderá e exiba o total em dias.
*/

using System;

class Program
{
    public static void Main()
    {
        int cigarSmokedPerDay, yearsSmoking;
        int totalTimeLost, totalDaysLost; 

        Console.Write("Quantos cigarros você fuma por dia? ");
        cigarSmokedPerDay = Convert.ToInt32(Console.ReadLine());

        Console.Write("Há quantos anos você fuma? ");
        yearsSmoking = Convert.ToInt32(Console.ReadLine());

        totalTimeLost = (cigarSmokedPerDay * 10) * (yearsSmoking * 365);
        totalDaysLost = (totalTimeLost / 60) / 24;

        Console.WriteLine("Por fumar {0} cigarros por dia durante {1} você perdeu {2} dias de vida", cigarSmokedPerDay, yearsSmoking, totalDaysLost); 

    }
}
