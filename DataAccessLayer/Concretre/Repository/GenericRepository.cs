using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concretre.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        
        public void Delete(T t)
        {
            using var context = new CvContext();
            context.Remove(t);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            using var context = new CvContext();
            return context.Set<T>().Find(id);
            
        }

        public List<T> GetListAll()
        {
            using var context = new CvContext();
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var context = new CvContext();


            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            using var context = new CvContext();
            context.Update(t);
            context.SaveChanges();

        }
    }
        
    
}
