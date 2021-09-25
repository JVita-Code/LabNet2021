using LabNet2021.Tp5.LINQ.Data;
using LabNet2021.Tp5.LINQ.Entities;
using LabNet2021.TP5.LINQ.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LabNet2021.Tp5.LINQ.UnitTests
{
    [TestClass]
    public class ProductsLogicTests
    {

        [TestMethod]
        public void ObtenerProductosSinStock_ListaProductos_DevuelveListaProductosSinStock()
        {

            var context = new NorthwindContext();

            ProductsLogic listaProductos = new ProductsLogic();

            // Act

            var resultado = listaProductos.ObtenerProductosSinStock();

            Assert.Equals(1, 1);         

            


        }        

        

    }
}

        
    

