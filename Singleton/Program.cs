using System;
using Singleton.Entities;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuracao configuracao = Configuracao.GetInstancia();
            
            Console.WriteLine(configuracao.getPropriedades("time-zone"));
        }
    }
}
