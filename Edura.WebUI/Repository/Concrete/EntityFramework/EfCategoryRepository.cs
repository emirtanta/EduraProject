using Edura.WebUI.Entity;
using Edura.WebUI.Models;
using Edura.WebUI.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Edura.WebUI.Repository.Concrete.EntityFramework
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryRepository
    {

        public EfCategoryRepository(EduraContext context):base(context)
        {
            
        }

        public EduraContext EduraContext
        {
            get { return context as EduraContext; }
        }

        public Category GetByName(string name)
        {
            return EduraContext.Categories.Where(i => i.CategoryName == name).FirstOrDefault();
        }

        public IEnumerable<CategoryModel> GettAllWithProductCount()
        {
            return GetAll().Select(i => new CategoryModel() {
                CategoryId = i.CategoryId,
                CategoryName = i.CategoryName,
                Count = i.productCategories.Count()
            });
        }

        //kategoriye ait ürünü silen fonksiyon
        public void RemoveFromCategory(int ProductId, int CategoryId)
        {
            var cmd = $"delete from ProductCategory where ProductId={ProductId} and CategoryId={CategoryId}";
            context.Database.ExecuteSqlCommand(cmd);
        }
    }
}
