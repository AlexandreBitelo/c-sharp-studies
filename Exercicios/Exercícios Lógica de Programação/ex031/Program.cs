/*
31) [DESAFIO] Crie um jogo de JoKenPo (Pedra-Papel-Tesoura) 
*/

using System;

class Program
{

    enum Shapes { Pedra, Papel, Tesoura };

    static void Main ()
    {
        Shapes shapeChooseByPlayer = Shapes.Pedra;
        Shapes shapeChooseByComputer = Shapes.Pedra;
        string winner; 
        Random random = new Random();
        
        interfaceStart();

        Console.WriteLine ("Escolha uma forma para jogar");
        showShapes();

        Console.Write ("Escolha: ");
        shapeChooseByPlayer = choicerShape ();

        shapeChooseByComputer = computerChoise (random);

        winner = whoiswinner (shapeChooseByPlayer, shapeChooseByComputer);




        Console.WriteLine ("A forma escolhida pelo player foi " + shapeChooseByPlayer);
        Console.WriteLine ("A forma escolhida pelo computador foi " + shapeChooseByComputer);



    }

    static void interfaceStart ()
    {
        Console.WriteLine ("--------------------------------------");
        Console.WriteLine ("|               JoKenPo              |");
        Console.WriteLine ("--------------------------------------");

    }

    static void showShapes ()
    {
        Console.WriteLine ("[1] Pedra");
        Console.WriteLine ("[2] Papel");
        Console.WriteLine ("[3] Tesoura");
    }

    static Shapes choicerShape ()
    {
        int choise  = -1;
        Shapes shape = Shapes.Pedra;

        choise = Convert.ToInt32(Console.ReadLine());
        switch (choise) {
            case 1: 
                shape = Shapes.Pedra;
                break;

            case 2: 
                shape = Shapes.Papel;
                break;

            case 3: 
                shape = Shapes.Tesoura;
                break;
            default:
                Console.Clear();
                Console.WriteLine ("Comando não reconhecido");
                break;
        } 

        return shape;
    }

    static Shapes computerChoise (Random random)
    {
        int indexChoise = random.Next (0, 3);
        Shapes shapeSelected = (Shapes)indexChoise;

        return shapeSelected;
    }

    static string whoiswinner (Shapes player1Choise, Shapes player2Choise)
    {
        Shapes winner = "";            

        // TESTES DENTRO DA ESTRUTURA CONDICIONAL

        player1Choise = Shapes.Pedra;
        player2Choise = Shapes.Papel;

        if ( player1Choise == Shapes.Pedra & player2Choise == Shapes.Papel )
        {
            winner = Convert.ToString(player2Choise);
        }

        Console.WriteLine ("Na variável winner está armazenado " + winner);

        return winner;

    }


}