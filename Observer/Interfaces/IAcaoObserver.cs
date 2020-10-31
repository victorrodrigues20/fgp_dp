using Observer.Entities;

namespace Observer.Interfaces
{
    public interface IInteressadoObserver
    {
         void NotificarAlteracao(Imovel imovel);
    }
}