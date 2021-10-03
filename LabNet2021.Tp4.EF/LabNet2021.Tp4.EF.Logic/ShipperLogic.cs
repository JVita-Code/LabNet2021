using LabNet2021.Tp4.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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

        public static void SetShipperDetails(string companyName, string companyPhone)
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

        public Shipper GetShipper(int id)
        {
            var shipper = context.Shippers.Where(s => s.ShipperID == id).FirstOrDefault();
            return shipper;
        }

        public void Update(Shipper field)
        {
            
            var shipperUpdate = context.Shippers.Find(field.ShipperID);

            if (shipperUpdate != null)
            {
                try
                {

                    {
                        shipperUpdate.CompanyName = field.CompanyName;
                        shipperUpdate.Phone = field.Phone;

                        context.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    throw e;                     
                }
            }
            else
            {
                context.Shippers.Add(field);
                context.SaveChanges();
            }

        }
    }
}

