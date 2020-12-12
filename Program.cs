using System;

namespace HoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime HoraAtual;

            HoraAtual = DateTime.Now;
            Console.Write("Data e Hora Atual: ");
            Console.WriteLine($"{HoraAtual}");
            Console.WriteLine();

            Console.WriteLine("Pressione ENTER para Sair!");
            Console.ReadKey();
        }
    }
}