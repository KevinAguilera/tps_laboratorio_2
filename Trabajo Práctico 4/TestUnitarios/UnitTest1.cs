using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using Excepciones;
using System.Collections.Generic;

// TEMA 16
namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(GustosException))]
        public void GustosException()
        {
            // Arrange
            Carrito miCarrito = new Carrito("Jorge");

            // Act
            List<Producto.GustoHelado> gustos = new List<Producto.GustoHelado>();
            gustos.Add(Producto.GustoHelado.Frutilla);
            gustos.Add(Producto.GustoHelado.Granizado);
  
            

            // Assert
            TortaHelada productoTorta = new TortaHelada();
            productoTorta.TamanioElegido = TortaHelada.Tamanio.Individual;
            productoTorta += Producto.GustoHelado.Frutilla;
            productoTorta += Producto.GustoHelado.Chocolate;
            productoTorta += Producto.GustoHelado.Chocolate;
       
            
            miCarrito += productoTorta;
            miCarrito.CalcularTotal();

            Carrito.Guardar(miCarrito);
        }

        [TestMethod]
        public void VerificarTxt()
        {
            Carrito v = new Carrito("Jorge");
            bool ret = Carrito.Guardar(v);

            Assert.IsTrue(ret);
        }

        [TestClass]
        public class TestPruebasEntidades
        {

            [TestMethod]
            public void ValidarListaProducto()
            {
                Pedido pedido = new Pedido();
                Assert.IsNotNull(pedido.PedidosEnPreparacion);
            }
        }
    }
}
