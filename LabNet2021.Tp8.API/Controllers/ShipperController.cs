using LabNet2021.Tp4.EF.Entities;
using LabNet2021.Tp4.EF.Logic;
using LabNet2021.Tp8.API.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;


namespace LabNet2021.Tp8.API.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ShipperController : ApiController
    {
        // GET: Shippers        

        ShipperLogic shipperlogic = new ShipperLogic();

        [HttpGet]
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
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                Shipper shipper = new Shipper()
                {
                    ShipperID = shipperAPI.ShipperID,
                    CompanyName = shipperAPI.CompanyName,
                    Phone = shipperAPI.Phone,
                };
                shipperlogic.Add(shipper);
                shipperAPI.ShipperID = shipper.ShipperID;

                return Created(new Uri(Request.RequestUri + "/" + shipper.ShipperID), shipperAPI);
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }            
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                shipperlogic.Delete(id);
                return Ok("El shipper fue eliminado.");
            }
            catch (NullReferenceException ex)
            {
                return NotFound();
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }

        [HttpPut]
        public IHttpActionResult Update2(int id, ShipperDto updatedShipper)
        {
            try
            {
                var shipperEncontrado = shipperlogic.GetShipper(id);

                if(shipperEncontrado == null)
                {
                    return NotFound();
                }

                Shipper shipper = new Shipper()
                {
                    CompanyName = updatedShipper.CompanyName,
                    Phone = updatedShipper.Phone,
                };

                shipperlogic.Update2(id, shipper);  
                return Ok("El shipper fue modificado");  
            }
            catch (Exception ex)
            {
                return BadRequest("Ha ocurrido un error");
            }                      
        }
    }
}