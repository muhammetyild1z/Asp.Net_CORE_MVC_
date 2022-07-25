using CoreAndFoot.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CoreAndFoot.Repositories
{
    public class GenericRepository<T> where T :class ,new()
    {
        Context c = new Context();

        public List<T> TList()
        {
            return c.Set<T>().ToList();
        }
       
        public void TRemove(T ct)
        {
            c.Set<T>().Remove(ct);
            c.SaveChanges();
        }

        public void TUpdate(T ct)
        {
            c.Set<T>().Update(ct);
            c.SaveChanges();
        }

        public T getT(int id)
        {
          return c.Set<T>().Find(id);

        }
        public List<T> TList(string p)
        {
            return c.Set<T>().Include(p).ToList();

        }
        public void TAdd(T ct)
        {
            c.Set<T>().Add(ct);
            c.SaveChanges();
        }
        // kaatagoriye göre ürün getirme işlemi
        public List<T> List(Expression <Func<T,bool>> filter)
        {
            return c.Set<T>().Where(filter).ToList();
        }
    }
}
