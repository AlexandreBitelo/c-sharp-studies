using System;

class Aula06
{
    public static void Main()
    {
        /*
        int n1, n2, n3;
        n1 = 10; n2 = 20; n3 = 30;

        // Formatação de saída, parecida com .format em Python
        // Console.WriteLine(n1 + " , " + n2 + " , " + n3);
        // Console.Write("n1=\t{0}, n2=\t{1}, n3=\t{2}", n1, n2, n3);
        */

        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("Produto.............: {0, 15}", produto);
        Console.WriteLine("Val.Compra.............: {0, 15:c}", valorCompra);
        Console.WriteLine("Lucro.............: {0, 15:p}", lucro);
        Console.WriteLine("Val.Venda.............: {0, 15:c}", valorVenda);



    }
}