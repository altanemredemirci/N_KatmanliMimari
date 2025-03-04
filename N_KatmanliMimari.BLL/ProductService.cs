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
    }
}
