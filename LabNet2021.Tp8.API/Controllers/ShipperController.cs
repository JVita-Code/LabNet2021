using LabNet2021.Tp4.EF.Entities;
using LabNet2021.Tp4.EF.Logic;
using LabNet2021.Tp8.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using HttpPatchAttribute = System.Web.Http.HttpPatchAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace LabNet2021.Tp8.API.Controllers
{
    public class ShipperController : ApiController
    {
        // GET: Shippers

        ShipperLogic shipperlogic = new ShipperLogic();        

        public List<ShipperDto> GetShippers()
        {
            List<ShipperDto> shipperAPI = shipperlogic.GetAll().Select(s => new ShipperDto
            {
                ShipperID = s.ShipperID,
                CompanyName = s.CompanyName,
                Phone = s.Phone,
            }).ToList();
            return shipperAPI;
        }  
        
        

        [HttpPost]
        public IHttpActionResult Add(ShipperDto shipperAPI)
        {
            try
            {
                Shipper shipper = new Shipper()
                {
                    ShipperID = shipperAPI.ShipperID,
                    CompanyName = shipperAPI.CompanyName,
                    Phone = shipperAPI.CompanyName,
                };
                shipperlogic.Add(shipper);
                return Ok("El Shipper fue añadido.");
                
            }
            catch (Exception)
            {

                return BadRequest("Error: verifique los datos");
            }
        }

        [HttpPost]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                shipperlogic.Delete(id);
                return Ok("El shipper fue eliminado.");
            }
            catch (Exception)
            {

                return BadRequest("Error: verifique los datos");
            }
        }

        [HttpPatch]
        public IHttpActionResult Update(ShipperDto shipperAPI)
        {

            try
            {
                Shipper shipper = new Shipper()
                {
                    ShipperID = shipperAPI.ShipperID,
                    CompanyName = shipperAPI.CompanyName,
                    Phone = shipperAPI.Phone,
                };
                shipperlogic.Update(shipper);
                return Ok("El shipper fue modificado.");

            }
            catch (Exception)
            {

                return BadRequest("Error: verifique los datos.");
            }
        }
















        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}