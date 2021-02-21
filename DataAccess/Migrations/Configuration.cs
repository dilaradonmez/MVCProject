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

            Category category1 = null;
            Category category2 = null;
            Category category3 = null;

            if (!context.Categories.Any())
            {
                List<Category> categories = new List<Category>()
                {
                    new Category{ CategoryName="Elektronik",MasterId=1,CreatedDate=DateTime.Now,UpdatedDate=DateTime.Now,},
                    new Category{ CategoryName="Kitap",MasterId=2,CreatedDate=DateTime.Now,UpdatedDate=DateTime.Now,},
                    new Category{ CategoryName="Oyun",MasterId=3,CreatedDate=DateTime.Now,UpdatedDate=DateTime.Now,}
                };

                context.Categories.AddRange(categories);
                context.SaveChanges();

                category1 = categories.Where(x => x.CategoryName == "Elektronik").FirstOrDefault();
                category2 = categories.Where(x => x.CategoryName == "Kitap").FirstOrDefault();
                category3 = categories.Where(x => x.CategoryName == "Oyun").FirstOrDefault();
            }

            SubCategory subCategory1 = null;
            SubCategory subCategory2 = null;
            SubCategory subCategory3 = null;


            if (!context.SubCategories.Any())
            {
                subCategory1 = new SubCategory { CategoryId = category1.ID, GetCategory = category1, SubCategoryName = "Telefon", Description = "asdadasdf", MasterId = 1 };
                subCategory2 = new SubCategory { CategoryId = category2.ID, GetCategory = category2, SubCategoryName = "Roman", Description = "asdadasdf", MasterId = 2 };
                subCategory3 = new SubCategory { CategoryId = category3.ID, GetCategory = category3, SubCategoryName = "Savaþ", Description = "asdadasdf", MasterId = 3 };


                List<SubCategory> subCategories = new List<SubCategory>
                {
                   subCategory1,subCategory2,subCategory3
                };

                context.SubCategories.AddRange(subCategories);
                context.SaveChanges();
            }

            if (!context.Products.Any())
            {
                List<Product> products = new List<Product>()
                {
                    new Product{ ImagePath="IPhone12.jpg",MasterId=1,SubCategory=subCategory1,SubCategoryId=subCategory1.ID,ProductName="IPhone 12",UnitPrice=20000,UnitsInStock=45},
                    new Product{ ImagePath="ZFold2.jpg",MasterId=2,SubCategory=subCategory1,SubCategoryId=subCategory1.ID,ProductName="Cesur Yeni Dünya",UnitPrice=18000,UnitsInStock=50},
                    new Product{ ImagePath="PS5.jpg",MasterId=3,SubCategory=subCategory3,SubCategoryId=subCategory3.ID,ProductName="PS 5",UnitPrice=8000,UnitsInStock=15}
                };
                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }

    }

}
