using System;

static public class Jogador
{
    static public int energia;
    static public bool isvivo;
    static public string nome;

    public static void iniciar (string n) {
        energia = 100;
        isvivo = true;
        nome = n;

    }

    public static void Info () {
        Console.WriteLine ("NOME: " + nome);
        Console.WriteLine ("ENERGIA: " + energia);
        Console.WriteLine ("VIVO: " + isvivo);
    }

}

class Inimigo
{
    public static bool alerta; 
    public string nome; 

    public Inimigo (string n) {
        alerta = false;
        this.nome = n; 
    }

    public void info() {
        Console.WriteLine("----- INFORMAÇÕES DO OBJETO INIMIGO -----");
        Console.WriteLine("NOME: " + nome);
        Console.WriteLine("ALERTA: " + alerta);
    }

}

public class Aula031
{
    static void Main () {
        Jogador.iniciar("Bruno");
      
        Inimigo n1 = new Inimigo("Doido");
        Inimigo n2 = new Inimigo("Maluco");
        Inimigo n3 = new Inimigo("Pirado");
        
        Inimigo.alerta = true;

        n1.info();
        n2.info();
        n3.info();
    }

}

