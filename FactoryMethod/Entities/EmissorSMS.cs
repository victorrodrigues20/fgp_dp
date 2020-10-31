using System;

namespace DesignPatterns 
{
    public class EmissorSMS : IEmissor {

        public void Enviar (string mensagem) 
        {
            Console.WriteLine ("Enviando mensagem por SMS: {0}", mensagem);
        }
    }
}