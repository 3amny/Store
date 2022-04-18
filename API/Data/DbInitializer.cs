using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if(context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product {
                    Name = "desdesed",
                    Description = "Fkesofkes",
                    Price = 242,
                    PictureUrl = "images/products/dwad",
                    Type = "didwa",
                    Brand = "Samsung",
                    QuantityInStock = 52
                },
                 new Product {
                    Name = "fesrfes",
                    Description = "Fhshes",
                    Price = 242,
                    PictureUrl = "images/products/esf",
                    Type = "fawf",
                    Brand = "Samsung",
                    QuantityInStock = 342
                },
                 new Product {
                    Name = "fsgsge",
                    Description = "kgjg",
                    Price = 242,
                    PictureUrl = "images/products/dwad",
                    Type = "htfj",
                    Brand = "Apple",
                    QuantityInStock = 167
                },
                 new Product {
                    Name = "fshs",
                    Description = "pkuj",
                    Price = 242,
                    PictureUrl = "images/products/dwad",
                    Type = "didwa",
                    Brand = "Apple",
                    QuantityInStock = 13
                },
                 new Product {
                    Name = "desdfhtfhesed",
                    Description = "hjtfjf",
                    Price = 242,
                    PictureUrl = "images/products/dwad",
                    Type = "jtfjftj",
                    Brand = "Apple",
                    QuantityInStock = 134
                }

            };
            foreach(var product in products){
                context.Products.Add(product);
            }
            context.SaveChanges();
        }
    }
}