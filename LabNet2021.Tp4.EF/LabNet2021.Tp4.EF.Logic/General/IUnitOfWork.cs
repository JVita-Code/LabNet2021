using LabNet2021.Tp4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Tp4.EF.Logic
{
    public interface IUnitOfWork : IDisposable
    {
        IShipperRepository Shippers { get; }

        void Save();
        
    }
}
