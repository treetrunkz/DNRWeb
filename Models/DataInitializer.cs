using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DNR_Aquatics.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<PugestSoundRegionsContext>
    {
        protected override void Seed(PugestSoundRegionsContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
           // GetProducts().ForEach(c => context.Categories.Add(c));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                        CategoryName = "Otter"
                    },
                    new Category
                    {
                        CategoryID = 2,
                        CategoryName = "Fishes"
                    },
                    new Category
                    {
                        CategoryID = 3,
                        CategoryName = "Whale"
                    }
                };
            return categories;
        }

        private static List<PugetSoundRegions> GetProducts()
        {
            var products = new List<PugetSoundRegions>
            {

            };
            return products;
        }
    }
}