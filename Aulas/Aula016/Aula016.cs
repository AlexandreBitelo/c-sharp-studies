using System;

class Aula016
{
    static void Main ()
    {
        int time = 0;
        char transport, choise = ' ';

        start:
        Console.Clear();

        Console.WriteLine ("Viagem de Belo Horizonte/MG a Vitória/ES");
        
        Console.WriteLine ("Escolha o transporte:");
        Console.WriteLine ("[A] -> Avião");
        Console.WriteLine ("[C] -> Carro");
        Console.WriteLine ("[O] -> Ônibus");
        Console.Write ("Escolha: ");
        transport = Convert.ToChar(Console.ReadLine());

        switch (transport)
        {
            case 'A':
                time = 50;
                break;
            
            case 'C':
                time = 480;
                break;
            
            case 'O': 
                time = 660;
                break;
            
            default: 
                time = -1;
                break;
        }

        if (time < 0)
        {
            Console.WriteLine ("Transporte indisponível");
        } else
        {
            Console.WriteLine ("Para o transporte escolhido o tempo é {0} minutos", time);
        }

        Console.Write("Calcular outro transporte? [S/N]: ");
        choise = char.Parse(Console.ReadLine());

        if (choise == 's' || choise == 'S')
        {
            goto start;
        } else
        {
            Console.Clear();
            Console.WriteLine ("Fim de Execução\n");
        }

    }
}