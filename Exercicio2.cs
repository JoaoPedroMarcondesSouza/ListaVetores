/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Program
{
    
    static double EncontrarMaiorElemento(double[] vetor)
    {
        double maior = vetor[0]; 
        
        foreach (double numero in vetor)
        {
            if (numero > maior)
            {
                maior = numero;
            }
        }
        
        return maior;
    }

    static void Main()
    {
        Console.Write("Informe o tamanho do vetor (N): ");
        int N = int.Parse(Console.ReadLine());

        double[] vetor = new double[N];

       
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Informe o elemento {i + 1}: ");
            vetor[i] = double.Parse(Console.ReadLine());
        }

       
        Console.WriteLine("O vetor é: " + string.Join(", ", vetor));

        
        double maiorElemento = EncontrarMaiorElemento(vetor);

      
        Console.WriteLine($"O maior elemento do vetor é: {maiorElemento}");
    }
}