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
        
        const int tamanhoMaximo = 50;
        char[] dna = new char[tamanhoMaximo];

        Console.WriteLine("Informe a fita de DNA (até 50 bases, usando A, T, C e G):");
        string entrada = Console.ReadLine();

        
        if (entrada.Length > tamanhoMaximo)
        {
            Console.WriteLine($"A fita de DNA deve ter no máximo {tamanhoMaximo} bases.");
            return;
        }


        for (int i = 0; i < entrada.Length; i++)
        {
            dna[i] = entrada[i];
        }

        
        char[] complementar = new char[entrada.Length];

        
        for (int i = 0; i < entrada.Length; i++)
        {
            switch (dna[i])
            {
                case 'A':
                    complementar[i] = 'T';
                    break;
                case 'T':
                    complementar[i] = 'A';
                    break;
                case 'C':
                    complementar[i] = 'G';
                    break;
                case 'G':
                    complementar[i] = 'C';
                    break;
                default:
                    Console.WriteLine($"Base inválida encontrada: {dna[i]}");
                    return;
            }
        }

        
        Console.WriteLine("A fita complementar de DNA é: " + new string(complementar));
    }
}