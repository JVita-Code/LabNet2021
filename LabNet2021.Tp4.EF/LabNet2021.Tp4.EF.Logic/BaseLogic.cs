using LabNet2021.Tp4.EF.Data;
using System.Collections.Generic;
using System.Linq;

namespace LabNet2021.Tp4.EF.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext context;

        public BaseLogic()
        {
            context = new NorthwindContext();
        }
        
    }
}
