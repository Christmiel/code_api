using CatalogueApp.Models;
using System;

namespace CatalogueApp.Services{
    public static class DbInit{
        public static void InitData(CatalogueDbRepository catalogDb)
        {   
                Console.WriteLine("Data Initiolization....");
                catalogDb.Categories.Add(new Category{Cat_Name="Ordinateur"});
                 catalogDb.Categories.Add(new Category{Cat_Name="Imprimantes"});
                  catalogDb.Categories.Add(new Category{Cat_Name="Telephones"});
                catalogDb.Products.Add(new Product{Prod_Name="iphone12", Prod_Price=12000, Cat_Id=3});
                catalogDb.Products.Add(new Product{Prod_Name="ecranplat", Prod_Price=19000, Cat_Id=2});
                catalogDb.Products.Add(new Product{Prod_Name="hp", Prod_Price=7000, Cat_Id=1});
                 catalogDb.Products.Add(new Product{Prod_Name="lenovo", Prod_Price=4000, Cat_Id=1});
                  catalogDb.Products.Add(new Product{Prod_Name="dello", Prod_Price=25000, Cat_Id=1});


                  catalogDb.SaveChanges();
        }

    }
}