using LabNet2021.Tp4.EF.Entities;
using LabNet2021.Tp4.EF.Logic;
using LabNet2021.Tp7.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabNet2021.Tp7.MVC.Controllers
{
    public class ShipperController : Controller
    {
        ShipperLogic shippersLogic = new ShipperLogic();
        // GET: Shipper
        public ActionResult Index()
        {
            
            List<Shipper> shippers = shippersLogic.GetAll();


            List<ShipperView> shippersView = shippers.Select(s => new ShipperView
            {
                ShipperID = s.ShipperID,
                CompanyName = s.CompanyName,
                Phone = s.Phone

            }).ToList();
            return View(shippersView);
        }        
        
        public ActionResult Delete(int id)
        {
            try
            {
                shippersLogic.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return View("Error");
            }    
            
        }

        public ActionResult InsertUpdate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertUpdate(ShipperView shippersView)
        {
            
            Shipper shipperEntity = new Shipper
            {

                CompanyName = shippersView.CompanyName,
                Phone = shippersView.Phone,
                ShipperID = shippersView.ShipperID
                
            };


            if (shipperEntity.ShipperID == 0)
                shippersLogic.Add(shipperEntity);
            else
            {
                try
                {
                    shippersLogic.Update(shipperEntity);
                }
                catch (DbEntityValidationException e)
                {

                    return View("Error");
                }
            }
            return RedirectToAction("Index");

        }
    }
}