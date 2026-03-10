using System;

class Aula024
{
    static void Main () {
        int valor1, valor2;

        valor1 = Convert.ToInt32(Console.ReadLine());
        valor2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine ("A soma de {0} e {1} é: {2}", valor1, valor2, soma (valor1, valor2));

    }    

    static int soma (int n1, int n2)
    {
        int res = n1 + n2;

        // Console.WriteLine ("A soma de {0} e {1} é: {2}", n1, n2, res);

        return res;
    }









    /*

    static void hello() {
        Console.WriteLine ("Hello!");
        Console.WriteLine ("Curso de C#");
        Console.WriteLine ("youtube.com/cfbcursos");


    }

    */





}