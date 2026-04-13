using System;

public class Jogador
{
    public int energia;
    public bool isvivo;
    public string nome;

    public Jogador () {
        energia = 100;
        isvivo = true;
        this.nome = "Jogador";

    }

    public Jogador (string n) {
        this.nome = n;
    }

    public Jogador (string n, int e) {
        energia = e;
        isvivo = true; 
        nome = n;

    }

    public Jogador (string n, int e, bool v) {
        energia = e;
        isvivo = v; 
        nome = n;
    }

    public void Info () {
        Console.WriteLine ("NOME: " + nome);
        Console.WriteLine ("ENERGIA: " + energia);
        Console.WriteLine ("VIVO: " + isvivo);
    }

}

public class Aula030
{
    static void Main () {

        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("Bruno");
        Jogador j3 = new Jogador("Théo", 100);
        Jogador j4 = new Jogador("BenegundesFirno", 0, false);

        Console.WriteLine("--------------");
        j1.Info();
        Console.WriteLine("--------------");
        j2.Info();
        Console.WriteLine("--------------");
        j3.Info();
        Console.WriteLine("--------------");
        j4.Info();
      
    }


}

