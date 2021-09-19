using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Tp4.EF.Logic
{
    public interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T field);
        void Update(T field);
        void Delete(int id);
    }
}
