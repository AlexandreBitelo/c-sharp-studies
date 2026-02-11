/*

29) Desenvolva um programa que leia o nome de um funcionário, seu salário, 
quantos anos ele trabalha na empresa e mostre seu novo salário, reajustado de 
acordo com a tabela a seguir: - 

Até 3 anos de empresa: aumento de 3% - 


entre 3 e 10 anos: aumento de 12.5% - 


10 anos ou mais: aumento de 20% 

*/

using System;

class Program
{
    static void Main ()
    {
        String name; 
        double salary, adjustedSalary = 0;
        int yearsWorked;

        Console.WriteLine ("CALCULADORA DE REAJUSTE SALARIAL");

        Console.Write ("Qual seu nome: ");
        name = Console.ReadLine();

        Console.Write ("Qual seu salario: ");
        salary = Convert.ToDouble(Console.ReadLine ());

        Console.Write ("Há quantos anos você trabalha na empresa: ");
        yearsWorked = Convert.ToInt32(Console.ReadLine());

        if ( yearsWorked <= 3 )
        {
            adjustedSalary = ( salary *  0.03) + salary;

        }
        else if (yearsWorked > 3 && yearsWorked < 10)
        {
            adjustedSalary = ( salary * 0.125 ) + salary;

        }
        else if ( yearsWorked >= 10 )
        {
            adjustedSalary = ( salary * 0.20 ) + salary;

        }
        else
        {
            Console.WriteLine ("NÚMERO NÃO RECONHECIDO");

        }

        Console.WriteLine ("Por trabalhar por {0} anos, você recebeu um aumento de salário de {1:c} para {2:c}", yearsWorked, salary, adjustedSalary); 

    }

}