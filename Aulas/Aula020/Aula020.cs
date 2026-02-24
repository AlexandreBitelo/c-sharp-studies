using System;


class Aula020
{
    static void Main ()
    {
        int[] num = new int[5];

        num [2] = 3;

        int contador = 0;
        while (contador < num.Length)
        {
            Console.WriteLine(num[contador]);

            contador++;
        }

        Console.WriteLine ("Fim da execução do programa!");
    }
}