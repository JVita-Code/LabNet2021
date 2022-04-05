using LabNet2021.Tp4.EF.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Tp4.EF.Logic
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected NorthwindContext _context;

        public Repository(NorthwindContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetItems()
        {
            return _context.Set<T>().ToList();
        }

        public T GetItem(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void AddItem(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void DeleteItem(int id)
        {
            var item = _context.Set<T>().Find(id);

            _context.Set<T>().Remove(item);
        }

        public void UpdateItem(T entity)
        {
            //_context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;            
        }

        //public void Save()
        //{
        //    _context.SaveChanges();
        //}
    }
}
