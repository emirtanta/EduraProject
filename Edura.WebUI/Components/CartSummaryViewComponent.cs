using Edura.WebUI.Infrastructer;
using Edura.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Components
{
    //layout bölümündeki cart bölgesinde ürün seçtiğimizde kartın içerisine veri atılınca içerisindeki ürünü gösterir
    public class CartSummaryViewComponent:ViewComponent
    {
        public string Invoke()
        {
            return HttpContext.Session.GetJson<Cart>("Cart")?.Products.Count().ToString() ?? "0";
        }
    }
}
