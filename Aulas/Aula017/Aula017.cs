using System;

class Aula017
{
    static void Main ()
    {
        /*
        Primeira forma de utilizar o array
        int [] n = new int[5];

        n[0] = 11;
        n[1] = 22;
        n[2] = 33;
        n[3] = 44;
        n[4] = 55;

        Console.WriteLine (n[4]);
        */

        /*

        Declarando o array com valores

        int [] num = new int [3] {55, 77, 99};

        Console.WriteLine (num[2]);

        */


        // Quando utilizamos esse tipo de declaração sem a chamada da classe, o tamanho do array é atribuído de acordo com os elementos que declararmos       
        // int [] num = {55, 77, 99, 66, 88};

        string[] veiculos = new string[3];

        veiculos[0] = "carro";
        veiculos[1] = "avião";
        veiculos[2] = "Navio";

        // Documentação


        int [] nomeDoVetor = {55, 77, 88};

    }
}