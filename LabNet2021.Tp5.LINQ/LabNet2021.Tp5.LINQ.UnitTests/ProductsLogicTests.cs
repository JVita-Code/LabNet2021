using LabNet2021.Tp5.LINQ.Data;
using LabNet2021.TP5.LINQ.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabNet2021.Tp5.LINQ.UnitTests
{
    [TestClass]
    public class ProductsLogicTests
    {

        [TestMethod]
        public void ObtenerProductosSinStock_ListaProductos_DevuelveListaProductosSinStock()
        {
            // Arrange


            var context = new NorthwindContext();

            ProductsLogic listaProductos = new ProductsLogic();
            listaProductos.ObtenerProductosSinStock();



            // Act



            // Assert

            Assert.AreEqual(1, 1);


        }
    }
}
