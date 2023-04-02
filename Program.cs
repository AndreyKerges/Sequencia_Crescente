
using System;

namespace exe_while_3tpa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n1 = 0;
            int n2 = 0;

            Console.Write("informe o 1 número :");
            n1 = int.Parse(Console.ReadLine()!);

            Console.Write("informe o 2 número :");
            n2 = int.Parse(Console.ReadLine()!);

            if (n2 >= n1)
            {
                int n = n1;
            while (n <= n2)
            {
                Console.WriteLine(n);
                n += 1;
            }
            }
            else
            {
                Console.WriteLine("Erro. O segundo número não pode ser menor que o primeiro.");
            }
        }
    }
}
