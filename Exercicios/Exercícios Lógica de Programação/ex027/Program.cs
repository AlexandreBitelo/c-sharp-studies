/*
27) Crie um programa que leia duas notas de um aluno e calcule a sua média, 
mostrando uma mensagem no final, de acordo com a média atingida: - Média até 4.9: REPROVADO - Média entre 5.0 e 6.9: RECUPERAÇÃO - Média 7.0 ou superior: APROVADO
*/

using System;

class Program
{
    static void Main ()
    {
        double [] grades = new double[2];
        double averege; 
        
        Console.WriteLine ("-- CALCULADORA DE NOTAS --"); 

        Console.Write ("Digite a primeira nota: ");
        grades[0] = Convert.ToDouble(Console.ReadLine());

        Console.Write ("Digite a segunda nota: ");
        grades[1] = Convert.ToDouble(Console.ReadLine());

        averege = ( grades[0] + grades[1] ) / 2;

        if ( averege > 7)
        {
            Console.WriteLine ("APROVADO");

        }
        else if ( averege > 5 & averege < 6.9 )
        {
            Console.WriteLine ("RECUPERAÇÃO");

        } else
        {
            Console.WriteLine ("REPROVADO");
            
        }

    }
}