using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var emissor = new EmissorFactory().Create(TipoEmissor.SMS);
            //var emissor = new EmissorFactory().Create(TipoEmissor.EMAIL);
            //var emissor = new EmissorFactory().Create(TipoEmissor.WHATSAPP);
            emissor.Enviar("teste envio");

            Console.Write("\nPressione qualquer tecla...");
            Console.ReadKey();
        }
    }
}
