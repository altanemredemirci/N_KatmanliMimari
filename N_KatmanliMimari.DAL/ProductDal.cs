using N_KatmanliMimari.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_KatmanliMimari.DAL
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            DataContext db = new DataContext();

            return db.Products.ToList();
        }
    }
}
