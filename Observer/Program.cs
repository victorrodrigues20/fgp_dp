using System;
using Observer.Entities;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var imovel = new Imovel()
            {
                Codigo = 1,
                Valor = 100000
            };

            var corretora1 = new Imobiliaria("Imobiliaria A");
            var corretora2 = new Imobiliaria("Imobiliaria B");

            imovel.RegistrarInteressado(corretora1);
            imovel.RegistrarInteressado(corretora2);

            imovel.Valor = 120000;

            var corretora3 = new Imobiliaria("Imobiliaria C");
            imovel.RegistrarInteressado(corretora3);

            imovel.Valor = 115000;
        }
    }
}
