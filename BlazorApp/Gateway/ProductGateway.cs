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
            if(rowAffected>0)
            {
                return true;
            }
            return false;
        }
       
    }
}
