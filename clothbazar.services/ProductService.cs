using clothbazar.database;
using clothbazar.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clothbazar.services
{
    public class ProductService
    {
        public void SaveProduct(Product product)
        {
            using(var context=new CBContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
                
            }

        }

        public List<Product> GetProducts()
        {
            using (var context = new CBContext())
            {
                return context.Products.ToList();
            }

        }

        public Product Getproduct(int ID)
        {
            using (var context = new CBContext())
            {
                return context.Products.Find(ID);
            }

        }

        public void UpdateProduct(Product product)
        {
            using (var context = new CBContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }

        public void DeleteProduct(int ID)
        {
            using (var context = new CBContext())
            {
                //context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                var product = context.Products.Find(ID);
                context.Products.Remove(product);
                context.SaveChanges();
            }

        }
    }
}
