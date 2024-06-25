using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor de N: ");
        int N = int.Parse(Console.ReadLine());

        if (N <= 0)
        {
            Console.WriteLine("Por favor, insira um número maior que zero.");
            return;
        }

        long[] fibonacci = new long[N];
        fibonacci[0] = 0;
        if (N > 1)
        {
            fibonacci[1] = 1;
        }

        for (int i = 2; i < N; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        Console.WriteLine("Os primeiros " + N + " números da sequência de Fibonacci são:");
        for (int i = 0; i < N; i++)
        {
            Console.Write(fibonacci[i] + " ");
        }
    }
}
