/*
31) [DESAFIO] Crie um jogo de JoKenPo (Pedra-Papel-Tesoura) 
*/

using System;
using System.Reflection.Metadata;

class Program
{

    enum Positions { Pedra, Papel, Tesoura };

    static void Main ()
    {
        String player1Choise;

        String [] shape = new string [3] {"Pedra", "Papel", "Tesoura"};

        int shapeChoise;

        Console.WriteLine ("--------------------------------------");
        Console.WriteLine ("|               JoKenPo              |");
        Console.WriteLine ("--------------------------------------");
        
        Console.WriteLine ("Escolha uma forma para jogar");
        Console.WriteLine ("[1] Pedra");
        Console.WriteLine ("[2] Papel");
        Console.WriteLine ("[3] Tesoura");
        Console.Write ("Escolha: ");

        shapeChoise = Convert.ToInt32(Console.ReadLine());

        switch (shapeChoise) {
            case 1: 
                player1Choise = shape[0];
                break;

            case 2: 
                player1Choise = shape[1];
                break;

            case 3: 
                player1Choise = shape[2];
                break;
        }

        

    }
}