using System.Collections.Generic;

namespace Singleton.Entities
{
    public class Configuracao
    {
        private Dictionary<string, string> propriedades;
        private static Configuracao instancia;

        private Configuracao()
        {
            this.propriedades = new Dictionary<string, string>();
            this.propriedades.Add("time-zone", "America/Sao_Paulo");
            this.propriedades.Add("currency-code", "BRL");            
        }

        public string getPropriedades(string nomePropriedade)
        {
            return this.propriedades[nomePropriedade];
        }

        public static Configuracao GetInstancia()
        {
            if (Configuracao.instancia == null)
                Configuracao.instancia = new Configuracao();

            return Configuracao.instancia;
        }
    }
}