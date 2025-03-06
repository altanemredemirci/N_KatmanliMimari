using N_KatmanliMimari.BLL;
using N_KatmanliMimari.Entity;

namespace N_KatmanliMimari.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Databaseden ürünleri Getir

            ProductService productService = new ProductService();

            #region Tüm Ürünler 
            //var products = productService.GetAll();
            #endregion

            #region Ürün Ekleme
            //Product product = new Product();
            //Console.WriteLine("Ürün adı:");
            //product.Name = Console.ReadLine();
            //Console.WriteLine("Ürün fiyatı:");
            //product.Price = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Ürün stok:");
            //product.Stock = Convert.ToInt16(Console.ReadLine());

            //productService.Create(product);
            #endregion

            #region Tüm Ürünler - Stok Filtresi
            //var urunler = productService.GetAll();
            #endregion

            #region Ürün Satın Alma - Stok Kontrolü
            //var products = productService.GetAll();

            //foreach (var item in products)
            //{
            //    Console.WriteLine($"{item.Id}-{item.Name}:{item.Price}");
            //}

            //Console.WriteLine("İstenilen Ürün Numarasu:");
            //int no = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("İstenilen Adet:");
            //int adet = Convert.ToInt32(Console.ReadLine());

            //string result = productService.Checkout(no, adet);

            //Console.WriteLine(result);
            #endregion

            #region Ürün Silme
            var products = productService.GetAll();
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Id}-{item.Name}:{item.Price}");
            }

            Console.WriteLine("Silenecek Ürün Numarasu:");
            int no = Convert.ToInt32(Console.ReadLine());

            if (productService.Delete(no))
            {
                Console.WriteLine("Ürün Başarıyla Silindi.");
            }
            else
            {
                Console.WriteLine("Ürün Silinemedi!!");
            }
            #endregion
        }
    }
}
