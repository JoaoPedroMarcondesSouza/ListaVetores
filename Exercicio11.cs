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
        
        Console.WriteLine("Digite a mensagem codificada:");
        string mensagemCodificada = Console.ReadLine();

        
        string mensagemDecodificada = "";

        
        for (int i = 0; i < mensagemCodificada.Length; i++)
        {
            
            if (mensagemCodificada[i] == 'p' && i + 1 < mensagemCodificada.Length)
            {
                
                mensagemDecodificada += mensagemCodificada[i + 1];
                
                i++;
            }
            else if (mensagemCodificada[i] != 'p') 
            {
                mensagemDecodificada += mensagemCodificada[i];
            }
        }

       
        Console.WriteLine("Mensagem decodificada:");
        Console.WriteLine(mensagemDecodificada);
    }
}