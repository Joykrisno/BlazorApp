using BlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Gateway
{
    public class ProductGateway
    {
        ApplicationDbContext _db = new ApplicationDbContext();

        public bool Add(Product product)
        {
            _db.products.Add(product);
            int rowAffected = _db.SaveChanges();
            if (rowAffected > 0)
            {
                return true;
            }
            return false;
        }

        public List<Product> GetAll()
        {
            return _db.products.ToList();
        }
        public Product GetById(int id)
        {
            return _db.products.FirstOrDefault(x => x.Id == id);
        }


        public bool Delete(int id)
        
        { 
            var product = _db.products.FirstOrDefault(x => x.Id == id);
            _db.products.Remove(product);
            int rowAffected = _db.SaveChanges();

            return rowAffected > 0;
        }

        public bool Update(Product product)
        {
            int rowAffected = _db.SaveChanges();
            if(rowAffected>0)
            {
                return true;
            }
            return false;
        }
       
    }
}
