/*
13) Faça um algoritmo que leia o salário de um funcionário, calcule e mostre o 
seu novo salário, com 15% de aumento.
*/

using System; 

class Program
{
    public static void Main()
    {
        double salary, salaryWithIncrease;

        Console.WriteLine("-- CALCULADORA DE AUMENTO --");

        Console.Write("Quanto é o seu salário atual: ");
        salary = Convert.ToDouble(Console.ReadLine());

        salaryWithIncrease = salary + (salary * 0.15);

        Console.WriteLine("Seu salário com 15% de aumento é {0, 0:c}", salaryWithIncrease); 
    }
}