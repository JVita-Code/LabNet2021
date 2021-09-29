using LabNet2021.Tp4.EF.Entities;
using LabNet2021.Tp4.EF.Logic;
using LabNet2021.Tp7.MVC.Models;
using System;
using System.Collections.Generic;
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
            var shippersLogic = new ShipperLogic();
            List<Shipper> shippers = shippersLogic.GetAll();


            List<ShipperView> shippersView = shippers.Select(s => new ShipperView
            {
                Id = s.ShipperID,
                CompanyName = s.CompanyName,
                Phone = s.Phone

            }).ToList();
            return View(shippersView);
        }

        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(ShipperView shipperView)
        {
            try
            {
                Shipper shipperEntity = new Shipper { ShipperID = shipperView.Id, CompanyName = shipperView.CompanyName, Phone = shipperView.Phone};

                shippersLogic.Add(shipperEntity);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
               
                return RedirectToAction("Index", "Error");
            }
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

                return RedirectToAction("Error");
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
                ShipperID = shippersView.Id,
                CompanyName = shippersView.CompanyName,
                Phone = shippersView.Phone,               
                
            };

            try
            {
                if (shippersLogic.GetAll().Any(a => a.ShipperID == shippersView.Id))
                {
                    shippersLogic.Update(shipperEntity);
                }
                else
                {
                    shippersLogic.Add(shipperEntity);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Error");
            }



        }
    }
}