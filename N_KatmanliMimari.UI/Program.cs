using N_KatmanliMimari.BLL;

namespace N_KatmanliMimari.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Databaseden ürünleri Getir

            ProductService productService = new ProductService();

            var products = productService.GetAll();
        }
    }
}
