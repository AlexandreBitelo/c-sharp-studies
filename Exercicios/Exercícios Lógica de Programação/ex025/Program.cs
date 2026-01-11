/*
25) [DESAFIO] Crie um programa que leia o tamanho de três segmentos de reta. 
Analise seus comprimentos e diga se é possível formar um triângulo com essas 
retas. Matematicamente, para três segmentos formarem um triângulo, o comprimento 
de cada lado deve ser menor que a soma dos outros dois.
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

        if (edge1 < (edge2 + edge3) && 
            edge2 < (edge1 + edge3) && 
            edge3 < (edge1 + edge2) )
        {
            Console.WriteLine ("Com estas medidas, é possível criar um triâgulo");
        }
        else
        {
            Console.WriteLine ("Com estas medidas NÃO é possível formar um triângulo");
        }
       
    }
}