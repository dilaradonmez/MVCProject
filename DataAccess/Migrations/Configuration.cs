namespace DataAccess.Migrations
{
    using DataAccess.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.Context.ProjectDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DataAccess.Context.ProjectDbContext context)
        {
            List<Product> products = new List<Product>()
            {
                new Product{
                    ID=Guid.NewGuid(),
                    ProductName="Lenova Laptop",
                    UnitPrice=5000,
                   

                },
                new Product{
                    ID=Guid.NewGuid(),
                    ProductName="IPhone",
                    UnitPrice=5000,

                }

            };
            foreach (var product in products)
            {
                context.Products.Add(product);
                context.SaveChanges();
            }

            List<Category> category = new List<Category>()
            {
                new Category
                {
                    ID=Guid.NewGuid(),
                    CategoryName="Phone",
                    Description="phones in stock",


                },
                new Category
                {
                    ID=Guid.NewGuid(),
                    CategoryName="Laptop",
                    Description="Laptop in stock"
                }
            };

            foreach (var categorys in category)
            {
                context.Categories.Add(categorys);
                context.SaveChanges();
            }
        }
        
    }
}
