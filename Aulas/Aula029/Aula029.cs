using System;

public class Jogador
{
    public int energia;
    public bool isvivo;
    public string nome;

    public Jogador (string nome) {
        energia = 100;
        isvivo = true; 
        this.nome = nome;

    }

    ~Jogador () {
        Console.WriteLine ("Jogador foi removido " + this.nome);
    }

}

public class Aula029
{
    static void Main () {
        string nome; 

        Console.Write ("Digite o nome do jogador 1: ");
        nome = Console.ReadLine();

        Jogador j1 = new Jogador(nome);
        Jogador j2 = new Jogador("Théo"); 

        j1.energia = 80;

        Console.WriteLine ("Nome do jogador 1: " + j1.nome);
        Console.WriteLine ("Nome do jogador 2: " + j2.nome);

    }


}
