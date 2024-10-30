/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Program
{
    
    static int ContarImpares(int[] vetor)
    {
        int contador = 0; 

        foreach (int numero in vetor)
        {
            if (numero % 2 != 0) 
            {
                contador++; 
            }
        }
        
        return contador; 
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

       
        int quantidadeImpares = ContarImpares(vetor);

        
        Console.WriteLine($"A quantidade de números ímpares no vetor é: {quantidadeImpares}");
    }
}