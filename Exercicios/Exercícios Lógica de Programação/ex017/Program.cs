/*
17) Escreva um programa que pergunte a velocidade de um carro. Caso ultrapasse 
80Km/h, exiba uma mensagem dizendo que o usuário foi multado. Nesse caso, exiba 
o valor da multa, cobrando R$5 por cada Km acima da velocidade permitida. 
*/

using System; 

class Program
{
    static void Main(String[] args)
    {
        int velocityLimit = 80;
        double velocity, fine = 0;
        Boolean fined = false;
        
        Console.WriteLine ("-- RADAR DE VELOCIDADE --");

        Console.Write ("Qual a velocidade do carro: ");
        velocity = Convert.ToDouble(Console.ReadLine());

        fined = velocity > velocityLimit;

        if (fined)
        {
            Console.WriteLine("LIMITE DE VELOCIDADE {0}Km/h", velocityLimit);

            fine = (velocity - velocityLimit) * 5;
            Console.WriteLine ("Você foi multado, o valor da multa é {0, 0:c}", fine);
        } else
        {
            Console.WriteLine ("LIMITE DE VELOCIDADE 80Km/h");
            Console.WriteLine ("DENTRO DO LIMITE DE VELOCIDADE");
        }
    } 
}