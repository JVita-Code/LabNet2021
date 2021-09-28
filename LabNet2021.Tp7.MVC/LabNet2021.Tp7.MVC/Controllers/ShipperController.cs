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
        ShipperLogic logic = new ShipperLogic();
        // GET: Shipper
        public ActionResult Index()
        {
            var logic = new ShipperLogic();
            List<Shipper> shippers = logic.GetAll();

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
                Shipper shipperEntity = new Shipper { CompanyName = shipperView.CompanyName };

                logic.Add(shipperEntity);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }
        public ActionResult Delete(int id)
        {
            logic.Delete(id);
            return RedirectToAction("Index");
        }
    }
}