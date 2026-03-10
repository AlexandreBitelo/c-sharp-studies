using System; 

class Aula025
{
    static void Main ()
    {
        int num = 10;
        int num2 = 15;

        dobrar (ref num);
        dobrar (ref num2);

        Console.WriteLine (num2);
        

    }

    static void dobrar (ref int valor)
    {
        valor *= 2;
    }



}