using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// ProdutoA2
    /// </summary>
    public class SamsungGalaxy : ISmartPhone
    {
        public string BuscarDestalhesModelo()
        {
            return "Model: Samsung Galaxy\nRAM: 2GB\nCamera: 13MP\n";
        }
    }
}
