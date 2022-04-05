using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Tp4.EF.Logic
{
    public interface IRepository<T>
    {
        //List<T> GetAll();
        IEnumerable<T> GetItems();
        T GetItem(int id);
        void AddItem(T entity);
        void UpdateItem(T entity);
        void DeleteItem(int id);

        //void Save();
    }
}
