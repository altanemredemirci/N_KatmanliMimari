using N_KatmanliMimari.DAL;
using N_KatmanliMimari.Entity;

namespace N_KatmanliMimari.BLL
{
    public class ProductService
    {
        ProductDal productDal = new ProductDal();

        public List<Product> GetAll()
        {
            return productDal.GetAll();
        }

        public int Create(Product p)
        {
            return productDal.Create(p);
        }

        public string Checkout(int Id, int adet)
        {
            if (Id <= 0)
            {
                return "Hatalı Ürün Numarası";
            }

            if (adet < 1)
            {
                return "Hatalı Adet Girişi";
            }

            return productDal.Checkout(Id, adet);
        }

        public bool Delete(int Id)
        {
            return productDal.Delete(Id);
        }
    }
}
