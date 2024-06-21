using Localized_E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Localized_E_commerce.Repository
{
    public class ProductRepository
    {
        public static LocalizedDatabaseEntities db = DatabaseSingleton.GetInstance();
        public static List<Product> getAllProduct()
        {

            return db.Products.Include(i => i.Images).Include(s => s.Sizes).ToList();
             
        }

        public static List<Image> getAllImageByProductId(int productId)
        {
            

            return db.Images.Where(x => x.productId == productId).ToList();
        }

        public static Product getProductById(int productId) {
            

            return db.Products.Where(x => x.Id == productId).FirstOrDefault();
         
        }

        public static List<Image> getImageById(int productId) {
            
            return db.Images.Where(x => x.Id == productId).ToList();
        }

        public static List<Size> getSizeById(int productId)
        {
            
            return db.Sizes.Where(x => x.Id == productId).ToList();
        }
    }
}