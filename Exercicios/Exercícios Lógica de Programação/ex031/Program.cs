/*
31) [DESAFIO] Crie um jogo de JoKenPo (Pedra-Papel-Tesoura) 
*/

using System;

public class Player
{
    public enum Formas {Pedra, Papel, Tesoura};
    public Formas formaEscolhida;
    public string nome; 

    public Player (string nome) {
        this.nome = nome;

    }

    public Formas escolherFormaAleatoria () {
        Random random = new Random();
        int indexDaEscolha = random.Next (0, 3);
        
        return (Formas)indexDaEscolha;
    }

    public Formas escolherForma (int indexDaEscolha) {
        
        return (Formas)( indexDaEscolha - 1);
    }

}

public class View
{

    public void exibirMenu () {
        Console.WriteLine ("-----------------------------------");
        Console.WriteLine ("|-------------JoKenPo-------------|");
        Console.WriteLine ("-----------------------------------");
    }

    public void apresentarFormas () {
        Console.WriteLine("[1] Pedra");
        Console.WriteLine("[2] Papel");
        Console.WriteLine("[3] Tesoura");

    }

    public void apresentarVencedor (Player Vencedor) {
        Console.WriteLine("------------------------------------");

        if (Vencedor == null) {
            Console.WriteLine("Empate");
            
        } else
        {
            Console.WriteLine("O vencedor é {0}", Vencedor.nome);

        }

        Console.WriteLine("------------------------------------");
    }

} 


public class Program
{
    public static void Main ()
    {
        View viewer = new View();
        Player jogador1 = new Player("Jogador");
        Player computador = new Player ("Computador");

        Console.Clear();
        viewer.exibirMenu();

        viewer.apresentarFormas(); 
        Console.Write ("Escolha uma forma para jogar: ");

        jogador1.formaEscolhida = jogador1.escolherForma(Convert.ToInt32(Console.ReadLine()));
        computador.formaEscolhida = computador.escolherFormaAleatoria();
        
        Console.Clear();

        Console.WriteLine ("Resultados...");
        Console.WriteLine ("JOGADOR 1: " + jogador1.formaEscolhida);
        Console.WriteLine ("COMPUTADOR: " + computador.formaEscolhida);

        viewer.apresentarVencedor(verificarVencedor (jogador1, computador));

    }

    public static Player verificarVencedor (Player jogador1, Player jogador2)
    {
        if (jogador1.formaEscolhida == jogador2.formaEscolhida) {   
            return null;
        }

        if ( jogador1.formaEscolhida == Player.Formas.Pedra && jogador2.formaEscolhida == Player.Formas.Tesoura ||
            jogador1.formaEscolhida == Player.Formas.Papel && jogador2.formaEscolhida == Player.Formas.Pedra ||
            jogador1.formaEscolhida == Player.Formas.Tesoura && jogador2.formaEscolhida == Player.Formas.Papel
        ){
            return jogador1;

        } else {  
            return jogador2;

        }

    }

}
