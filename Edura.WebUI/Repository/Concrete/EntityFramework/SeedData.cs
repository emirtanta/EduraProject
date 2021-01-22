using Edura.WebUI.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Repository.Concrete.EntityFramework
{
    //test verisi oluşturmak için tanımlandı
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetRequiredService<EduraContext>();

            context.Database.Migrate();

            if (!context.Products.Any())
            {
                var products = new[]
                {
                    new Product(){ ProductName="Photo Camera",Price=1000,Image="product1.jpg",isHome=true,isApproved=true,isFeatured=true,Description="<b>Deneme Açıklama 1</b>",HtmlContent="Deneme açıklama detay 1",DateAdded=DateTime.Now.AddDays(-10)},
                    new Product(){ ProductName="Webcam",Price=200,Image="product2.jpg",isHome=false,isApproved=true,isFeatured=true,Description="Deneme Açıklama 2",HtmlContent="Deneme açıklama detay 2",DateAdded=DateTime.Now.AddDays(-15)},
                    new Product(){ ProductName="Hand Bag",Price=500,Image="product3.jpg",isHome=true,isApproved=true,isFeatured=true,Description="Deneme Açıklama 3",HtmlContent="Deneme açıklama detay 3",DateAdded=DateTime.Now.AddDays(-20)},
                    new Product(){ ProductName="Sofa",Price=3000,Image="product4.jpg",isHome=true,isApproved=true,isFeatured=true,Description="Deneme Açıklama 4",HtmlContent="Deneme açıklama detay 4",DateAdded=DateTime.Now.AddDays(-25)}
                };

                context.Products.AddRange(products);

                var categories = new[]
                {
                    new Category(){CategoryName="Electronics"},
                    new Category(){CategoryName="Accessories"},
                    new Category(){CategoryName="Furniture"}
                };

                context.Categories.AddRange(categories);

                var productcategories = new[]
                {
                    new ProductCategory(){ Product=products[0],Category=categories[0]},
                    new ProductCategory(){ Product=products[1],Category=categories[0]},
                    new ProductCategory(){ Product=products[3],Category=categories[2]},
                    new ProductCategory(){ Product=products[3],Category=categories[1]}
                };

                context.AddRange(productcategories);

                var images = new[]
                {
                    new Image(){ ImageName="product1.jpg",ProductId=1},
                    new Image(){ ImageName="product2.jpg",ProductId=1},
                    new Image(){ ImageName="product3.jpg",ProductId=1},
                    new Image(){ ImageName="product4.jpg",ProductId=1},

                    new Image(){ ImageName="product1.jpg",ProductId=2},
                    new Image(){ ImageName="product2.jpg",ProductId=2},
                    new Image(){ ImageName="product3.jpg",ProductId=2},
                    new Image(){ ImageName="product4.jpg",ProductId=2},

                    new Image(){ ImageName="product1.jpg",ProductId=3},
                    new Image(){ ImageName="product2.jpg",ProductId=3},
                    new Image(){ ImageName="product3.jpg",ProductId=3},
                    new Image(){ ImageName="product4.jpg",ProductId=3},

                    new Image(){ ImageName="product1.jpg",ProductId=4},
                    new Image(){ ImageName="product2.jpg",ProductId=4},
                    new Image(){ ImageName="product3.jpg",ProductId=4},
                    new Image(){ ImageName="product4.jpg",ProductId=4}
                };

                context.Images.AddRange(images);

                var attributes = new[]
                {
                    new ProductAttribute(){ Attribute="Display",Value="15.6",ProductId=1},
                    new ProductAttribute(){ Attribute="Processor",Value="Intel i7",ProductId=1},
                    new ProductAttribute(){ Attribute="RAM Memory",Value="8 GB",ProductId=1},
                    new ProductAttribute(){ Attribute="Hard Disk",Value="1 TB",ProductId=1},
                    new ProductAttribute(){ Attribute="Color",Value="Black",ProductId=1},

                    new ProductAttribute(){ Attribute="Display",Value="15.6",ProductId=2},
                    new ProductAttribute(){ Attribute="Processor",Value="Intel i7",ProductId=2},
                    new ProductAttribute(){ Attribute="RAM Memory",Value="8 GB",ProductId=2},
                    new ProductAttribute(){ Attribute="Hard Disk",Value="1 TB",ProductId=2},
                    new ProductAttribute(){ Attribute="Color",Value="Black",ProductId=2},

                    new ProductAttribute(){ Attribute="Display",Value="15.6",ProductId=3},
                    new ProductAttribute(){ Attribute="Processor",Value="Intel i7",ProductId=3},
                    new ProductAttribute(){ Attribute="RAM Memory",Value="8 GB",ProductId=3},
                    new ProductAttribute(){ Attribute="Hard Disk",Value="1 TB",ProductId=3},
                    new ProductAttribute(){ Attribute="Color",Value="Black",ProductId=3},

                    new ProductAttribute(){ Attribute="Display",Value="15.6",ProductId=4},
                    new ProductAttribute(){ Attribute="Processor",Value="Intel i7",ProductId=4},
                    new ProductAttribute(){ Attribute="RAM Memory",Value="8 GB",ProductId=4},
                    new ProductAttribute(){ Attribute="Hard Disk",Value="1 TB",ProductId=4},
                    new ProductAttribute(){ Attribute="Color",Value="Black",ProductId=4}
                };

                context.ProductAttributes.AddRange(attributes);

                context.SaveChanges();
            }
        }
    }
}
