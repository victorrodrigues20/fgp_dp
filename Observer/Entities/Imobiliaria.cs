using System;
using Observer.Interfaces;

namespace Observer.Entities
{
    public class Imobiliaria : IInteressadoObserver
    {
        private string nome;

        public Imobiliaria(string nome)
        {
            this.nome = nome;
        }

        public void NotificarAlteracao(Imovel imovel)
        {
            Console.WriteLine("{0} sendo notificado", this.nome);
            Console.WriteLine("O imovel {0} teve seu valor alterado para {1}", 
                imovel.Codigo, imovel.Valor);
        }
    }
}