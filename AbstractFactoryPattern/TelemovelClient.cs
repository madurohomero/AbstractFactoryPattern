using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// Client
    /// </summary>
    public class TelemovelClient
    {
        ISmartPhone smartPhone;
        INormalPhone normalPhone;

        public TelemovelClient(ITelemovel telemovelFactory)
        {
            smartPhone = telemovelFactory.BuscarSmartPhone();
            normalPhone = telemovelFactory.BuscarNormalPhone();
        }

        public string BuscarSmartPhoneModeloDetalhe()
        {
            return smartPhone.BuscarDestalhesModelo();
        }

        public string BuscarNormalPhoneModeloDetalhe()
        {
            return normalPhone.BuscarDetalhesModelo();
        }

    }
}
