using LabNet2021.Tp4.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabNet2021.Tp4.EF.Logic
{
    public class ShipperLogic : BaseLogic, IABMLogic<Shipper>
    {
        public void Add(Shipper field)
        {
            context.Shippers.Add(field);
            context.SaveChanges();
        }     

        public void SetShipperDetails(string companyName, string companyPhone)
        {
            ShipperLogic shipperLogic = new ShipperLogic();

            shipperLogic.Add(new Shipper
            {
                CompanyName = companyName,
                Phone = companyPhone
            });
        }

        public void Delete(int id)
        {
            var deleteId = context.Shippers.Find(id);
            context.Shippers.Remove(deleteId);
            context.SaveChanges();
        }

        public List<Shipper> GetAll()
        {
            return context.Shippers.ToList();
        }

        public void Update(Shipper field)
        {
            var shipperUpdate = context.Shippers.Find(field.ShipperID);

            if (shipperUpdate == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                shipperUpdate.CompanyName = field.CompanyName;

                shipperUpdate.Phone = field.Phone;
                context.SaveChanges();
            }

        }

        

    }
}
