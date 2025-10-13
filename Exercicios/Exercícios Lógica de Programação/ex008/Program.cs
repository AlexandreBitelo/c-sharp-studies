/*
8) Desenvolva um programa que leia uma distância em metros e mostre os valores 
relativos em outras medidas. 
Ex:  
Digite uma distância em metros: 185.72 
A distância de 85.7m corresponde a: 
0.18572Km   1857.2dm 
1.8572Hm    18572.0cm 
18.572Dam   185720.0mm 
*/


using System; 

class Program
{
    public static void Main()
    {
        double distance;

        Console.Write("Digite uma distância em metros: ");
        distance = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("A distância de {0}m corresponde a: ", distance);

        Console.WriteLine("{0}Km {1, 15}dm", distance / 1000, distance * 10);
        Console.WriteLine("{0}Hm {1, 15}cm", distance / 100, distance * 100);
        Console.WriteLine("{0}Dam {1, 15}mm", distance / 10, distance * 1000);
    }
}