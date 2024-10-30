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
        Console.Write("Informe o tamanho do vetor de caracteres: ");
        int tamanho = int.Parse(Console.ReadLine());

        char[] vetor = new char[tamanho];

       
        Console.WriteLine("Digite os caracteres:");
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Caracter {i + 1}: ");
            vetor[i] = Console.ReadLine()[0];
        }

        
        int quantidade = vetor.Length;

        
        Console.WriteLine("O vetor em ordem inversa é:");
        for (int i = quantidade - 1; i >= 0; i--)
        {
            Console.Write(vetor[i] + " ");
        }
    }
}