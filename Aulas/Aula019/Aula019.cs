using System;


class Aula019
{
    static void Main ()
    {
        int[] num = new int[5];

        for (int cont = 0; cont < num.Length; cont++)
        {   
            num [cont] = 0;

            Console.WriteLine ("Valor de num na posição {0}: {1} ",cont, num[cont]);
        }


    }
}