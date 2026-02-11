/*

30) [DESAFIO] Refaça o algoritmo 25, acrescentando o recurso de mostrar que tipo 
de triângulo será formado:  

- EQUILÁTERO: todos os lados iguais 


- ISÓSCELES: dois lados iguais - 


- ESCALENO: todos os lados diferentes 

*/

using System;

class Program
{
    static void Main ()
    {
        double edge1, edge2, edge3;  
        
        Console.WriteLine ("-- CALCULADORA DE FORMAÇÃO DE TRIÂNGULOS --");

        Console.Write ("Tamanho do primeiro segmento : ");
        edge1 = Convert.ToDouble(Console.ReadLine());

        Console.Write ("Qual o tamanho do segundo segmento: ");
        edge2 = Convert.ToDouble(Console.ReadLine ());

        Console.Write ("Qual o tamanho do terceiro segmento: ");
        edge3 = Convert.ToDouble(Console.ReadLine());

        if ( (edge1 == edge2) & (edge1 == edge3) & (edge2 == edge3))
        {
            Console.WriteLine ("Este é um triângulo Equilátero");
        } 
        else if ( ( edge1 == edge2 ) | ( edge2 == edge3 ) | (edge3 == edge1))
        {
            Console.WriteLine("Este é um triângulo Isóceles");
        }
        else
        {
            Console.WriteLine ("Este é um triângulo Escaleno");
        }
       
    }

}