using LabNet2021.Tp4.EF.Entities;
using LabNet2021.Tp4.EF.Logic;
using LabNet2021.Tp7.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LabNet2021.Tp7.MVC.Controllers
{
    public class ShipperController : Controller
    {
        private const String RESULTADO = "borrado";

        ShipperLogic shippersLogic = new ShipperLogic();
        
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
        
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                shippersLogic.Delete(id);                
                return Content(RESULTADO);
            }
            catch (Exception ex)
            {
                return View("Error");
            }   
        }

        public ActionResult InsertUpdate(int? id)
        {
            ShipperView shipper = new ShipperView();

            if(id != null)
            {
                var shipperToUpdate = shippersLogic.GetShipper(id);
                shipper.CompanyName = shipperToUpdate.CompanyName;
                shipper.Phone = shipperToUpdate.Phone;
                shipper.ShipperID = shipperToUpdate.ShipperID;
            }            
            return View(shipper);
        }

        [HttpPost]
        public ActionResult InsertUpdate(ShipperView shipper)
        {
            
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(shipper);
                }

                Shipper shipperEntity = new Shipper()
                {
                    ShipperID = shipper.ShipperID,
                    CompanyName = shipper.CompanyName,
                    Phone = shipper.Phone
                };

                if (shipperEntity.ShipperID == 0)
                {
                    shippersLogic.Add(shipperEntity);
                    return RedirectToAction("Index");
                }
                else
                {
                    shippersLogic.Update(shipperEntity);
                    return RedirectToAction("Index");
                }                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}