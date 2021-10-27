using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabNet2021.Tp7.MVC.Models
{
    public class ShipperView
    {
        //[Required(ErrorMessage = "Para insertar shipper, coloque 0.")]
        public int ShipperID { get; set; }

        [ShipperFormCustomValidation]        
        [StringLength(40)]
        public string CompanyName { get; set; }

        [ShipperFormCustomValidation]        
        [Phone]
        public string Phone { get; set; }
    }
}
