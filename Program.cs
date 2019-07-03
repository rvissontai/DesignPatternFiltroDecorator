using System;
using System.Collections.Generic;

namespace ContaFraudeDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<Conta>()
            {
                new Conta(){ Titular = "Menor que 100", Saldo = 90,  DataAbertura = DateTime.Now.AddMonths(-3) },
                new Conta(){ Titular = "Mês corrente e menor que 100", Saldo = 50,  DataAbertura = DateTime.Now },
                new Conta(){ Titular = "Mês corrente", Saldo = 100,  DataAbertura = DateTime.Now },
                new Conta(){ Titular = "Igual que quinhentos mil", Saldo = 500000,  DataAbertura = DateTime.Now.AddMonths(-3) },
                new Conta(){ Titular = "Maior que quinhentos mil", Saldo = 500100,  DataAbertura = DateTime.Now.AddMonths(-3) },
                new Conta(){ Titular = "Válido 1", Saldo = 150000,  DataAbertura = DateTime.Now.AddMonths(-3) },
                new Conta(){ Titular = "Válido 2", Saldo = 92754,  DataAbertura = DateTime.Now.AddMonths(-3) },
                new Conta(){ Titular = "Válido 3", Saldo = 12410,  DataAbertura = DateTime.Now.AddMonths(-3) },
            };

            Filtro filtro = new FiltroMenorQue100(new FiltroMaiorQueQuinhentosMil(new FiltroMesCorrente()));

            

            var retorno = filtro.Filtra(contas);

            

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
