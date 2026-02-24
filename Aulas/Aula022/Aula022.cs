using System; 

class Aula022
{
    static void Main ()
    {
        int [] num = new int [5] {11, 22, 33, 44, 55};

        
        for (int cont = 0; cont < num.Length; cont++)
        {
            num[cont] = 0;
            
        }
        

        foreach (int n in num) {
            Console.WriteLine (n);
        }





    }
}