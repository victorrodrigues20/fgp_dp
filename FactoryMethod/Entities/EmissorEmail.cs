using System;

namespace DesignPatterns 
{
    public class EmissorEmail : IEmissor {
        
        public void Enviar (string mensagem) 
        {
            Console.WriteLine ("Enviando mensagem por E-mail: {0}", mensagem);
        }
    }
}