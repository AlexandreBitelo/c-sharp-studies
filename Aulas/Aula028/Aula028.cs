using System; 

public class Jogador {
    public int energia = 100; 
    public bool isvivo = true;

    


}


class Aula028 {
    public static void Main () {
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();

        j1.energia = 80;

        Console.WriteLine ("A energia do Jogador 1 é " + j1.energia );
        Console.WriteLine ("A energia do Jogador 2 é " + j2.energia );

    }

}