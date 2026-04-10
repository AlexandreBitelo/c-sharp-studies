/*
Tenha um método chamado MaiorNumero
Use params
Receba vários números inteiros
Retorne o maior número entre eles
*/ 

using System;


class Program
{
    static void Main ()
    {
        Console.WriteLine ( maiorNumero ( 3, 7, 2, 9, 5 ) );
    }

    static int maiorNumero (params int[] numeros) {
        int numeroMaior = 0;

        if (numeros.Length < 1) {
            return -1;


        }else if (numeros.Length < 2) {
            return numeros[0];



        }else {
            for (int cont = 0; cont < numeros.Length; cont++) {   
                if (numeros[cont] > numeroMaior)
                {
                    numeroMaior = numeros[cont];


                }


            }

            return numeroMaior;
        }

    }

}


