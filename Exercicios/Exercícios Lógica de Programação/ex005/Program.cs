/*
5) Faça um programa que leia as duas notas de um aluno em uma matéria e mostre 
na tela a sua média na disciplina. 
Ex:  
Nota 1: 4.5 
Nota 2: 8.5 
A média entre 4.5 e 8.5 é igual a 6.5 
*/

using System;

class Program
{
    public static void Main()
    {
        double grade1, grade2, average; 

        Console.Write("Nota 1: ");
        grade1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nota 2: ");
        grade2 = Convert.ToDouble(Console.ReadLine());

        average = ((grade1 + grade2) / 2);

        Console.WriteLine("A média entre {0} e {1} é igual a {2}", grade1, grade2, average);
    }
}