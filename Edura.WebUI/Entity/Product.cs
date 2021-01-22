using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Entity
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }
        public Double Price { get; set; }
        public string Image { get; set; }

        public string Description { get; set; }
        public string HtmlContent { get; set; }
        public DateTime DateAdded { get; set; }

        public bool isApproved { get; set; }
        public bool isHome { get; set; }
        public bool isFeatured { get; set; }

        //product-catery arasında çoka çok ilişki
        public List<ProductCategory> ProductCategories { get; set; }

        //product ile image arasında 1-cok ilişki kuruldu
        public List<Image> Images { get; set; }

        //product-productAttribute(Ürün detay) tablosu arasında 1-çok ilişiki
        public List<ProductAttribute> Attributes { get; set; }
    }
}
