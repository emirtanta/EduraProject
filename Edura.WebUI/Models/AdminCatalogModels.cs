using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Models
{
    public class AdminEditCategoryModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<AdminEditCategoryProduct> Products { get; set; }

        //product sınıfındaki tüm değerleri kullanmamak için tanımladık
        public class AdminEditCategoryProduct
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public string Image { get; set; }
            public bool isApproved { get; set; }
            public bool isHome { get; set; }
            public bool isFeatured { get; set; }
        }
    }
}
