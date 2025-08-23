using System; 

namespace Aula02
{
    class Porgram
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello World");

            if (args.GetLength(0) > 0)
            {
                Console.Write(args.GetValue(0));
            }

            
        }
    }
}