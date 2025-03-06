using N_KatmanliMimari.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_KatmanliMimari.DAL
{
    public class ProductDal
    {
        DataContext db;

        public ProductDal()
        {
           db = new DataContext();
        }
        public List<Product> GetAll()
        {
            //return db.Products.ToList();

            var urunler = db.Products.Where(i => i.Stock > 0).ToList();

            return urunler;
        }

        public int Create(Product p)
        {
            db.Products.Add(p);

            return db.SaveChanges();
        }

        public string Checkout(int Id,int adet)
        {
            //var product = db.Products.Where(i => i.Id == Id).FirstOrDefault();
            //Product product = db.Products.FirstOrDefault(i => i.Id == Id);

            var product = db.Products.Find(Id);

            if (product != null)
            {
                if (product.Stock >= adet)
                {
                    product.Stock -= adet;
                    db.SaveChanges();
                    return "İyi Alışverişler";
                }
                else
                    return "Yetersiz Stok!";
            }
            else
            {
                return "Girilen Ürün Bulunamadı.";
            }
        }

        public bool Delete(int Id)
        {
            var product = db.Products.Find(Id);

            if (product == null)
                return false;

            db.Products.Remove(product);
            db.SaveChanges();

            return true;
        }
    }
}
