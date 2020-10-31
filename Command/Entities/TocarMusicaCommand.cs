using Command.Interfaces;
using System.IO;

namespace Command.Entities
{
    public class TocarMusicaCommand : IComando
    {
        private Player _player;
        private FileInfo _file;

        public TocarMusicaCommand(Player player, FileInfo file)
        {
            this._player = player;
            this._file = file;
        }

        public void Executar()
        {
            this._player.Play(this._file);
        }
    }
}