/*
28) Faça um programa que leia a largura e o comprimento de um terreno 
retangular, calculando e mostrando a sua área em m². O programa também 
devemostrar a classificação desse terreno, de acordo com a lista abaixo: -

 Abaixo de 100m² = TERRENO POPULAR - 
 
 Entre 100m² e 500m² = TERRENO MASTER - 
 
 Acima de 500m² = TERRENO VIP
*/

using System; 

class Program
{
    static void Main ()
    {
        double [] dimensions = new double [2];
        double area; 

        Console.WriteLine ("-- CALCULADORA DE CLASSIFICAÇÃO DE TERRENOS --");

        Console.Write ("Digite o comprimento do terreno (em metros): ");
        dimensions[0] = Convert.ToDouble(Console.ReadLine());

        Console.Write ("Qual a profundidade do terreno (em metros): ");
        dimensions[1] = Convert.ToDouble(Console.ReadLine());

        area = dimensions[0] * dimensions[1]; 

        if ( area < 100 )
        {
            Console.WriteLine ("TERRENO POPULAR");
        } 
        else if ( area > 100 & area < 500 ) 
        {
            Console.WriteLine ("TERRENO MASTER");
        }
        else
        {
            Console.WriteLine ("TERRENO VIP");
        }

    }
}