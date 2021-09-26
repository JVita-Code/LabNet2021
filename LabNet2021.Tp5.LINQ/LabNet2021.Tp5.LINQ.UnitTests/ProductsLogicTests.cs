using LabNet2021.Tp5.LINQ.Data;
using LabNet2021.Tp5.LINQ.Entities;
using LabNet2021.TP5.LINQ.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LabNet2021.Tp5.LINQ.UnitTests
{
    [TestClass]
    public class ProductsLogicTests
    {
        

        [TestMethod]
        public void ObtenerProductosSinStock_ListaProductos_DevuelveListaTipoProductos()
        {

            var context = new NorthwindContext();
            ProductsLogic listaProductos = new ProductsLogic();
            
            
            var resultado = listaProductos.ObtenerProductosSinStock();            



            Assert.AreEqual(typeof(List<Product>), resultado.GetType());            

        } 
        
        [TestMethod]
        public void ObtenerProductosSinStock_ListaProductos_DevuelveListaProductosConStock()
        {
            var context = new NorthwindContext();
            ProductsLogic listaProductos = new ProductsLogic();



            var resultado = listaProductos.ObtenerProductosSinStock();

            
            
            var asd = 5; // cantidad de productos que devuelve consulta a través de sql manager

            Assert.AreEqual(asd, resultado.Count);

        }

        





    }
}

        
    

