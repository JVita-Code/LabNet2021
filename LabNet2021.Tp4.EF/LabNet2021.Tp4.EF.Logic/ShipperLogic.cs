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
            try
            {
                context.Shippers.Add(field);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }            
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
            try
            {
                var deleteId = context.Shippers.Find(id);
                context.Shippers.Remove(deleteId);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public List<Shipper> GetAll()
        {
            return context.Shippers.ToList();
        }

        public Shipper GetShipper(int? id)
        {
            try
            {
                var shipper = context.Shippers.Where(s => s.ShipperID == id).FirstOrDefault();
                return shipper;
            }
            catch (Exception ex)
            {
              throw ex;
            }            
        }

        public void Update(Shipper shipperUpdated)
        {
            try
            {
                var shipperToUpdate = context.Shippers.Find(shipperUpdated.ShipperID);                
                {
                    shipperToUpdate.CompanyName = shipperUpdated.CompanyName;
                    shipperToUpdate.Phone = shipperUpdated.Phone;

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update2(int id, Shipper updatedShipper)
        {

            try
            {
                var shipperToUpdate = context.Shippers.Find(id);

                {
                    shipperToUpdate.CompanyName = updatedShipper.CompanyName;
                    shipperToUpdate.Phone = updatedShipper.Phone;

                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }            
        }
    }
}

