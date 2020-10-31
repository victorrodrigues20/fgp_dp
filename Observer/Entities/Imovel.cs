using System.Collections.Generic;
using Observer.Interfaces;

namespace Observer.Entities
{
    public class Imovel
    {
        public int Codigo { get; set; }
        private double _valor;

        public double Valor 
        { 
            get { return _valor; } 
            set 
            {
                this._valor = value;

                foreach (var interessado in this.interessados)
                {
                    interessado.NotificarAlteracao(this);
                }
            }
        }

        private HashSet<IInteressadoObserver> interessados = new HashSet<IInteressadoObserver>();

        public void RegistrarInteressado(IInteressadoObserver interessado)
        {
            this.interessados.Add(interessado);
        }

        public void CancelarInteressado(IInteressadoObserver interessado)
        {
            this.interessados.Remove(interessado);
        }
    }
}