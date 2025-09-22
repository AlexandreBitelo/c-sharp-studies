using System;

class Aula08
{
    public static void Main()
    {
        int valor1, valor2, soma;
        string nome;

        Console.Write("Digite o primeiro valor: ");
        valor1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo Valor: ");
        valor2 = Convert.ToInt32(Console.ReadLine());

        soma = valor1 + valor2;

        Console.WriteLine("A soma de {0} mais {1} é igual a {2}", valor1, valor2, soma);

    }
}