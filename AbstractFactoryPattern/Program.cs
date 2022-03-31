using AbstractFactoryPattern.ConcretsFactory;
using AbstractFactoryPattern.Interfaces;
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITelemovel nokiaTelemovel = new Nokia();
            TelemovelClient nokiaClient = new TelemovelClient(nokiaTelemovel);

            Console.WriteLine("**************** NOKIA ****************");
            Console.WriteLine(nokiaClient.BuscarSmartPhoneModeloDetalhe());
            Console.WriteLine(nokiaClient.BuscarNormalPhoneModeloDetalhe());

            ITelemovel samsungTelemovel = new Samsung();
            TelemovelClient samsungClient = new TelemovelClient(samsungTelemovel);

            Console.WriteLine("**************** SAMSUNG ****************");
            Console.WriteLine(samsungClient.BuscarSmartPhoneModeloDetalhe());
            Console.WriteLine(samsungClient.BuscarNormalPhoneModeloDetalhe());

            Console.ReadKey();
        }
    }
}
