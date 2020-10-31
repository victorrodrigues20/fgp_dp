using System;

namespace DesignPatterns
{
    public class EmissorFactory
    {
        public IEmissor Create(TipoEmissor tipoEmissor)
        {
            switch(tipoEmissor)
            {
                case TipoEmissor.SMS:
                    return new EmissorSMS();
                case TipoEmissor.EMAIL:
                    return new EmissorEmail();
                case TipoEmissor.WHATSAPP:
                    return new EmissorWhatsApp();
                default:
                    throw new ArgumentException("Tipo de emissor não suportado");
            }
        }
    }
}