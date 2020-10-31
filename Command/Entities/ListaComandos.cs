using System.Collections.Generic;
using Command.Interfaces;

namespace Command.Entities
{
    public class ListaComandos
    {
        private List<IComando> comandos = new List<IComando>();
        
        public void Adicionar(IComando comando)
        {
            this.comandos.Add(comando);
        }

        public void Executar()
        {
            foreach (IComando comando in this.comandos)
            {
                comando.Executar();
            }
        }
    }
}