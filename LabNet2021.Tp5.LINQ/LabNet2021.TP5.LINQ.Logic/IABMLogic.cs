using LabNet2021.Tp5.LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP5.LINQ.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T newRegion);
        void Update(T region);
        void Delete(int id);
    }
}
