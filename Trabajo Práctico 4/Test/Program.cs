using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Carrito miCarrito = new Carrito("Jorge");

            List<Producto.GustoHelado> gustos = new List<Producto.GustoHelado>();
            gustos.Add(Producto.GustoHelado.Frutilla);
            gustos.Add(Producto.GustoHelado.Granizado);

            /*Helado productoHelado = new Helado();
            productoHelado.TamanioDelHelado = Helado.Tamanio.Cucurucho;
            productoHelado.TamanioDelHelado = Helado.Tamanio.Cuarto;
            productoHelado.TamanioDelHelado = Helado.Tamanio.Medio;
            productoHelado.TamanioDelHelado = Helado.Tamanio.Kilo;
            productoHelado += Producto.GustoHelado.Frutilla;
            productoHelado += Producto.GustoHelado.Mascarpone;*/

            TortaHelada productoTorta = new TortaHelada();
            productoTorta.TamanioElegido = TortaHelada.Tamanio.Individual;
            productoTorta += Producto.GustoHelado.Americana;
            productoTorta += Producto.GustoHelado.Chocolate;
           

            //miCarrito += productoHelado;
            miCarrito += productoTorta;
            miCarrito.CalcularTotal();

            Console.WriteLine(Carrito.Guardar(miCarrito));
            Console.ReadKey();
            Console.Clear();
        }
    }
}
