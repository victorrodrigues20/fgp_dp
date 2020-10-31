using Command.Interfaces;
using System.IO;

namespace Command.Entities
{
    public class DiminuirVolumeCommand : IComando
    {
        private Player _player;
        private int _nivel;

        public DiminuirVolumeCommand(Player player, int nivel)
        {
            this._player = player;
            this._nivel = nivel;
        }

        public void Executar()
        {
            this._player.DiminuirVolume(this._nivel);
        }
    }
}