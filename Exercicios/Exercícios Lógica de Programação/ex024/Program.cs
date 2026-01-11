/*
24) Faça um algoritmo que pergunte a distância que um passageiro deseja 
percorrer em Km. Calcule o preço da passagem, cobrando R$0.50 por Km para 
viagens até 200Km e R$0.45 para viagens mais longas.
*/

using System; 

class Program
{
    static void Main ()
    {
        double distance, pricePerKm, totalPrice; 

        Console.WriteLine ("-- CALCULADORA DE PREÇO POR QUILOMETROS PERCORRIDOS --");

        Console.Write ("Quantos Km você gostaria de percorrer: ");
        distance = Convert.ToDouble(Console.ReadLine ());

        if (distance < 200)
        {
            pricePerKm = 0.50;
        } else
        {
            pricePerKm = 0.45;
        }

        totalPrice = distance * pricePerKm;

        Console.WriteLine ("Para percorrer {0}Km custará {1, 0:c}", distance, totalPrice);
    }
}