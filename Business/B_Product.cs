using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Product
    {
        public static List<ProductEntity> ProductList ()
        {
            using (var db = new InventaryContext())
            {
                return db.Product.ToList();
            }
        }

        public static ProductEntity ProductById(string Id)
        {
            using (var db = new InventaryContext())
            {
                return db.Product.ToList().LastOrDefault(p => p.ProductId == Id);
            }
        }

        public static void CreateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Product.Add(oProduct);
                db.SaveChanges();
            }
        }

        public static void UpdateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext()) 
            { 
                db.Product.Update(oProduct);
                db.SaveChanges();
            }
        }
    }
}
