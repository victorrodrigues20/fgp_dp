using System;
using System.IO;

namespace Command.Entities
{
    public class Player
    {
        public void Play(FileInfo file)
        {
            Console.WriteLine("Tocar Musica: " + file.FullName);
        }

        public void AumentarVolume(int nivel)
        {
            Console.WriteLine("Aumentar Volume em " + nivel);
        }

        public void DiminuirVolume(int nivel)
        {
            Console.WriteLine("Diminuir Volume em " + nivel);
        }
    }
}