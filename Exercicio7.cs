/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe o tamanho dos vetores (N): ");
        int N = int.Parse(Console.ReadLine());

        
        int[] vetorA = new int[N];
        int[] vetorB = new int[N];
        int[] vetorResultado = new int[N];

        
        Console.WriteLine("Preencha o vetor A:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            vetorA[i] = int.Parse(Console.ReadLine());
        }

        
        Console.WriteLine("Preencha o vetor B:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            vetorB[i] = int.Parse(Console.ReadLine());
        }


        for (int i = 0; i < N; i++)
        {
            vetorResultado[i] = vetorA[i] * vetorB[i];
        }

        
        Console.WriteLine("O vetor resultante da multiplicação é: " + string.Join(", ", vetorResultado));
    }
}
