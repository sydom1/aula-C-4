using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("11 - Projeto Calculando Poupança");

        double investimento = 1000.0;

        //rendimento de 0.5% (0.005) ao mês
        //mês 1
        // investimento = investimento * 0.005;

        int mes = 1;

        while (mes <= 12)

        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " voce tem " + investimento);

           // mes = mes + 1; e a mesma coisa que o mes++
           mes ++;
        }


        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }


}