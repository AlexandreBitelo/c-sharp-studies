using System; 

class Aula021
{
    static void Main ()
    {
        String userKey = "123";
        String userTry; 
        int flag = 0; 
        

        Console.WriteLine ("VERIFICADOR DE SENHA");
        
        do
        {
            if (flag < 0)
            {
                Console.Clear();
                Console.WriteLine ("Senha Incorreta, tente novamente. ");
            }

            Console.Write ("Digite Sua Senha: ");
            userTry = Console.ReadLine ();
            
            flag = -1;
        } while (userKey != userTry);

        Console.WriteLine ("Senha Correta!");
        Console.WriteLine ("Fim da execução do programa!");
    }
}