
using System;

namespace exe_while_3tpa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //declarações das variáveis "n1 e n2" como um inteiro, e atribuição inicial de valor zero
            int n1 = 0;
            int n2 = 0;

            //exibe a mensagem "-----NÚMEROS EM SEQUÊNCIA CRESCENTE-----" no console
            Console.WriteLine("-----NÚMEROS EM SEQUÊNCIA CRESCENTE-----");

            //exibe a mensagem "informe o 1 número :" no console
            Console.Write("informe o 1 número :");
            //leitura do valor digitado pelo usuário para a variável "n1", convertendo a entrada em um número inteiro
            n1 = int.Parse(Console.ReadLine()!);

            // exibe a mensagem "informe o 2 número :" no console
            Console.Write("informe o 2 número :");
            //leitura do valor digitado pelo usuário para a variável "n2", convertendo a entrada em um número inteiro
            n2 = int.Parse(Console.ReadLine()!); 

            //verifica se n2 é maior ou igual a n1
            if (n2 >= n1) 
            {
                int n = n1; //declaração da variável "n" como um inteiro, e atribuição do valor de "n1"
            while (n <= n2) //enquanto "n" for menor ou igual a "n2", execute o bloco de código abaixo
            {
                Console.WriteLine(n); // exibe o valor de "n" na tela
                n += 1; //adiciona 1 ao valor de "n"
            }
            }
            else //caso a condição "if" seja falsa, execute o bloco de código abaixo
            {
                Console.WriteLine("Erro. O segundo número não pode ser menor que o primeiro.");
            }
        }
    }
}
