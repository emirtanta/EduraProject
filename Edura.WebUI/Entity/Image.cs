using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Entity
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }

        public string ImageName { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
