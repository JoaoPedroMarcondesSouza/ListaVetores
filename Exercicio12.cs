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
        double[] notas = new double[5];

        
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite a nota {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
        }

        
        double maior = notas[0];
        double menor = notas[0];

        
        for (int i = 1; i < 5; i++)
        {
            if (notas[i] > maior)
                maior = notas[i];
            if (notas[i] < menor)
                menor = notas[i];
        }

        
        double soma = 0;
        int contagem = 0;

        for (int i = 0; i < 5; i++)
        {
            if (notas[i] != maior && notas[i] != menor)
            {
                soma += notas[i];
                contagem++;
            }
        }

        
        if (contagem == 0)
        {
            soma = 3 * maior;
        }
        else if (contagem == 1)
        {
            
            soma += maior * 2;
        }
        else if (contagem == 2)
        {
            
            soma += maior;
        }

        
        Console.WriteLine($"{soma:F1}");
    }
}