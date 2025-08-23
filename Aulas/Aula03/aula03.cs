using System;

class Aula03
{
    static void Main(string[] args)
    {
        // byte n1 = 10; // 0 e 255
        // int num = -100;
        // char letra = 'f';
        // float valor = 5.3f;
        // string nome = "Alexandre";

        int num1 = 0, num2 = 0, res;

        num1 = 10;
        num2 = 2;
        res = num1 * num2;

        // var aux = nome; //Não é recomendavel alterar durante o programa

        Console.WriteLine("A multiplicaçao de " + num1 + " e " + num2 + " e igual a " + num1 * num2);

    }
}