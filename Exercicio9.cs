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
        Console.Write("Informe o tamanho do vetor (N): ");
        int N = int.Parse(Console.ReadLine());

        int[] vetor = new int[N];

        
        Console.WriteLine("Preencha o vetor:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        
        Console.Write("Digite um número para verificar quantas vezes aparece no vetor: ");
        int numeroBuscado = int.Parse(Console.ReadLine());

       
        int contador = 0;
        foreach (int numero in vetor)
        {
            if (numero == numeroBuscado)
            {
                contador++;
            }
        }

        
        Console.WriteLine("Os elementos do vetor são: " + string.Join(", ", vetor));

        
        Console.WriteLine($"O número {numeroBuscado} aparece {contador} vez(es) no vetor.");
    }
}