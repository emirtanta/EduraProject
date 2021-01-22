using Edura.WebUI.Entity;
using Edura.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Edura.WebUI.Repository.Concrete.EntityFramework
{
    public class EfOrderRepository : EfGenericRepository<Order>,IOrderRepository
    {
        //private EduraContext context;

        public EfOrderRepository(EduraContext context):base(context)
        {
            //context = ctx;
        }

        //public void Add(Order entity)
        //{
        //    context.Orders.Add(entity);
        //}

        //public void Delete(Order entity)
        //{
        //    context.Orders.Remove(entity);
        //}

        //public void Edit(Order entity)
        //{
        //    context.Entry<Order>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //}

        //public IQueryable<Order> Find(Expression<Func<Order, bool>> predicate)
        //{
        //    return context.Orders.Where(predicate);
        //}

        //public Order Get(int id)
        //{
        //    return context.Orders.FirstOrDefault(x => x.OrderId == id);
        //}

        //public IQueryable<Order> GetAll()
        //{
        //    return context.Orders;
        //}

        //public void Save()
        //{
        //     context.SaveChanges();
        //}
    }
}
