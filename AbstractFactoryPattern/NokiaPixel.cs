using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// ProdutoA1
    /// </summary>
    public class NokiaPixel : ISmartPhone
    {
        public string BuscarDestalhesModelo()
        {
            return "Model: Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
        }
    }
}
