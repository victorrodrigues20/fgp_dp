using System;
using System.IO;
using Command.Entities;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            ListaComandos playlist = new ListaComandos();

            playlist.Adicionar(new TocarMusicaCommand(player, new FileInfo("Musica1.mp3")));
            playlist.Adicionar(new AumentarVolumeCommand(player, 3));

            playlist.Adicionar(new TocarMusicaCommand(player, new FileInfo("Musica2.mp3")));
            playlist.Adicionar(new DiminuirVolumeCommand(player, 3));

            playlist.Adicionar(new TocarMusicaCommand(player, new FileInfo("Musica3.mp3")));
            playlist.Adicionar(new DiminuirVolumeCommand(player, 3));  

            playlist.Executar();

            Console.ReadKey();          
        }
    }
}
