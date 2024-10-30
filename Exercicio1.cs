/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Program
{
   
    static int SomarElementos(int[] vetor)
    {
        int soma = 0;
        foreach (int numero in vetor)
        {
            soma += numero;
        }
        return soma;
    }

    static void Main()
    {
        Console.Write("Informe o tamanho do vetor (N): ");
        int N = int.Parse(Console.ReadLine());

        int[] vetor = new int[N];

        
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Informe o elemento {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

       
        int somaTotal = SomarElementos(vetor);

       
        Console.WriteLine($"A soma dos elementos do vetor é: {somaTotal}");
    }
}