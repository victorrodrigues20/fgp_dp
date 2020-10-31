using System;

namespace DesignPatterns 
{
    public class EmissorWhatsApp : IEmissor
    {        
        public void Enviar (string mensagem) 
        {
            Console.WriteLine ("Enviando mensagem por " +
                "WhatsApp: {0}", mensagem);
        }
    }
}

