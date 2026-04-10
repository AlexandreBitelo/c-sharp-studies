using System;

class Aula027
{
    static void Main ()
    {
        soma(10, 5, 2, 4, 7);


    }

    static void soma (params int[]n)
    {
        int res = 0;

        if (n.Length < 1) {
            Console.WriteLine ("Não existem valores a serem somados");

        } else if (n.Length < 2) {
            Console.WriteLine ("Valores insuficientes para soma: {0}", n[0]);

        } else
        {
            for (int cont = 0; cont < n.Length; cont++) {
                res += n[cont];
            }

            Console.WriteLine ("A soma dos valores é: {0}", res);
        }

    }



}