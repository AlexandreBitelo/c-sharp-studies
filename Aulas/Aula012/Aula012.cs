// CALCULADORA DE NOTAS

using System; 

class Aula012
{
    static void Main (String[] args)
    {
        double num1, num2, media = 0;
        
        Console.WriteLine ("-- Calculadora de Notas --");
        
        Console.Write (" NOTA 1: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write ("NOTA 2: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        media = ( num1 + num2 ) / 2; 

        if ( media > 6) {
            Console.WriteLine ("Aprovado(a). Média {0}", media);
        
        } else {
            Console.WriteLine ("Reprovado(a). Média {0}", media);

        }
    }
}