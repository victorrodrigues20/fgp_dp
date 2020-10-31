using Adapter.Interfaces;

namespace Adapter.Entities
{
    public class AdapterTomada : TomadaDeTresPinos, ITomada
    {
        public void Ligar()
        {
            this.NovoLigar();
        }
    }
}