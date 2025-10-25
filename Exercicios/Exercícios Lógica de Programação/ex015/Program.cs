/*
15) Crie um programa que leia o número de dias trabalhados em um mês e mostre o 
salário de um funcionário, sabendo que ele trabalha 8 horas por dia e ganha R$25 
por hora trabalhada.
*/

using System; 

class Program
{
    public static void Main()
    {
        int numberOfWorkedDays;
        double finalPayment, payPerHour = 25;

        Console.WriteLine("-- Calculadora de salário por hora --");

        Console.Write("Dias do mês trabalhados: ");
        numberOfWorkedDays = Convert.ToInt32(Console.ReadLine());

        finalPayment = (numberOfWorkedDays * 8) * payPerHour;

        Console.WriteLine("RESULTADO...");
        Console.WriteLine("Você receberá {0} por trabalhar por {1} dias recebendo {2} por hora", finalPayment, numberOfWorkedDays, payPerHour);  


    }
}