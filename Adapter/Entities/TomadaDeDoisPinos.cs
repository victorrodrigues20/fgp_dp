using System;
using Adapter.Interfaces;

namespace Adapter.Entities
{
    public class TomadaDeDoisPinos : ITomada
    {
        public void Ligar()
        {
            Console.WriteLine("Ligado na tomada de dois pinos");
        }
    }
}