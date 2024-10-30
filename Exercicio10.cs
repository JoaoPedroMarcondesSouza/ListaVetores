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
        Console.Write("Informe o número de lançamentos do dado (N): ");
        int N = int.Parse(Console.ReadLine());

        
        int[] resultados = new int[N];

        
        Console.WriteLine("Digite os resultados dos lançamentos (números de 1 a 6):");
        for (int i = 0; i < N; i++)
        {
            int resultado;
            do
            {
                Console.Write($"Lançamento {i + 1}: ");
                resultado = int.Parse(Console.ReadLine());
                if (resultado < 1 || resultado > 6)
                {
                    Console.WriteLine("Resultado inválido! Digite um número entre 1 e 6.");
                }
            } while (resultado < 1 || resultado > 6);
            resultados[i] = resultado;
        }

        
        int[] contagem = new int[6]; 

        
        foreach (int resultado in resultados)
        {
            contagem[resultado - 1]++; 
        }

        
        Console.WriteLine("Número de ocorrências de cada face:");
        for (int i = 0; i < contagem.Length; i++)
        {
            Console.WriteLine($"Face {i + 1}: {contagem[i]} ocorrência(s)");
        }
    }
}