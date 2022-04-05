using LabNet2021.Tp4.EF.Data;
using LabNet2021.Tp4.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabNet2021.Tp4.EF.Logic
{
    public class ShipperRepository : Repository<Shipper>, IShipperRepository
    {      
        public ShipperRepository(NorthwindContext context)
            :base(context)
        {
            
        }
    }
}
