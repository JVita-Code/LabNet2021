using LabNet2021.Tp4.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Tp4.EF.Logic
{
    public class UnitOfWork : IUnitOfWork
    {
        private NorthwindContext _context;
        private IShipperRepository _shipperRepository;
        private bool disposed = false;

        public UnitOfWork(NorthwindContext context)
        {
            _context = context;             
        }

        public IShipperRepository Shippers
        {
            get
            {
                if (_shipperRepository == null)
                {
                    _shipperRepository = new ShipperRepository(_context);
                }

                return _shipperRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
