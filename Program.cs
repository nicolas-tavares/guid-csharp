using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {

            // Guid = 32 caracteres hexadecimais e 36 formatado pra string padrão com hífens

            var id1 = Guid.NewGuid();
            var id2 = Guid.NewGuid();


            Console.WriteLine("\nPROJETO GUIDS\n");
            Console.WriteLine("==============");
            Console.WriteLine("\nGuids gerados:\n");
            Console.WriteLine(id1);
            Console.WriteLine(id2 + "\n");

            if (id1 == id2)
            {
                Console.WriteLine("Guids são iguais.\n");
            }
            else
            {
                Console.WriteLine("Guids são diferentes.\n");
            }


            Console.WriteLine("==============");
            Console.WriteLine("\nGuids com 8 caracteres apenas:\n");
            Console.WriteLine(id1.ToString().Substring(0, 8));
            Console.WriteLine(id2.ToString().Substring(0, 8) + "\n");

        }
    }
}
