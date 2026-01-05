/*
19) Crie um algoritmo que leia o nome e as duas notas de um aluno, calcule a sua 
média e mostre na tela. No final, analise a média e mostre se o aluno teve ou 
não um bom aproveitamento (se ficou acima da média 7.0).
*/

using System; 

class Program
{
    static void Main(String[] args)
    {
        String name; 
        double grade1, grade2, averege = 0;
        
        Console.WriteLine ("-- CALCULADORA DE APROVEITAMENTO --");

        Console.Write ("Qual seu nome? ");
        name = Console.ReadLine(); 

        Console.Write ("Qual sua primeira nota? ");
        grade1 = Convert.ToDouble(Console.ReadLine ());

        Console.Write ("Qual sua segunda nota? ");
        grade2 = Convert.ToDouble(Console.ReadLine());

        averege = (grade1 + grade2) / 2;

        if (averege > 7)
        {
            Console.WriteLine ("Você teve um bom aproveitamento, sua média final foi {0}", averege);
            
        } else
        {
            Console.WriteLine ("Você não teve um bom aproveitamento, sua média final foi {0}", averege);
            
        }
    }
}