using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Interfaces
{
    public interface ITelemovel
    {
        INormalPhone BuscarNormalPhone();
        ISmartPhone BuscarSmartPhone();
    }
}
