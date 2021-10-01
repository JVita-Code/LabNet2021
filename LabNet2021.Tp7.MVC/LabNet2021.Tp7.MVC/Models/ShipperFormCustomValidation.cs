using LabNet2021.Tp4.EF.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabNet2021.Tp7.MVC.Models
{
    public class ShipperFormCustomValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var shipper = (ShipperView)validationContext.ObjectInstance;

            return (shipper.Phone != null && shipper.CompanyName !=null ) 
                ? ValidationResult.Success 
                : new ValidationResult("Este campo no puede quedar vacío.");         
        }
    }
}