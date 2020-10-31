using Command.Interfaces;
using System.IO;

namespace Command.Entities
{
    public class AumentarVolumeCommand : IComando
    {
        private Player _player;
        private int _nivel;

        public AumentarVolumeCommand(Player player, int nivel)
        {
            this._player = player;
            this._nivel = nivel;
        }

        public void Executar()
        {
            this._player.AumentarVolume(this._nivel);
        }
    }
}