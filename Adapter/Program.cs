using System;
using Adapter.Entities;
using Adapter.Interfaces;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ITomada tomada = new AdapterTomada();
            tomada.Ligar();

            tomada = new TomadaDeDoisPinos();
            tomada.Ligar();
        }
    }
}
