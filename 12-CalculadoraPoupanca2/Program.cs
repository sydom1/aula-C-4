using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("12 - Projeto Calculando Poupança");

        double investimento = 1000.0;

        for (int mes = 1; mes <= 12; mes++)

        {
            // investimento *= 1.005; simplificando a escrita do codigo abaixo.
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " voce tem " + investimento);


        }


        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }


}