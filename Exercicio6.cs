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

        
        int[] numeros = new int[N];
        Random random = new Random();

        
        for (int i = 0; i < N; i++)
        {
            numeros[i] = random.Next(1, 101); 
        }

        
        Console.WriteLine("Números sorteados: " + string.Join(", ", numeros));

        
        Console.Write("Digite um número para verificar se está no vetor: ");
        int numeroBuscado = int.Parse(Console.ReadLine());

       
        bool encontrado = false;
        int posicao = -1;

        for (int i = 0; i < N; i++)
        {
            if (numeros[i] == numeroBuscado)
            {
                encontrado = true;
                posicao = i; 
                break; 
            }
        }

        
        if (encontrado)
        {
            Console.WriteLine($"O número {numeroBuscado} está na posição {posicao}.");
        }
        else
        {
            Console.WriteLine($"O número {numeroBuscado} não está no vetor.");
        }
    }
}