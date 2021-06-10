using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Entidades
{
    public class Carrito
    {
        private List<Producto> productos;
        private string nombreCliente;
        private double total;
        private int numeroDePedido;

        #region "Constructores" 
        /// <summary>
        /// Constructor que incializa los datos del carrito
        /// </summary>
        public Carrito()
        {
            Random random = new Random();
            this.productos = new List<Producto>();
            this.nombreCliente = random.Next(11111, 99999).ToString();
            this.total = 0;
        }

        /// <summary>
        /// Constructor que pide el nombre del cliente
        /// </summary>
        /// <param name="nombreCliente">nombre del cliente</param>
        public Carrito(string nombreCliente) : this()
        {
            this.nombreCliente = nombreCliente;


        }
        #endregion


        #region Operadores
        /// <summary>
        /// Operador que agrega un producto de tipo Helado al carrito de compras
        /// </summary>
        /// <param name="carrito">carrito</param>
        /// <param name="helado">Helado</param>
        /// <returns></returns>
        public static Carrito operator +(Carrito carrito, Helado helado)
        {
            if (helado != null)
            {
                carrito.productos.Add(helado);
            }

            return carrito;
        }

        /// <summary>
        /// Operador que agrega un producto de tipo torta al carrito de compras
        /// </summary>
        /// <param name="carrito">carrito</param>
        /// <param name="torta">torta</param>
        /// <returns></returns>
        public static Carrito operator +(Carrito carrito, TortaHelada torta)
        {
            if (torta != null)
            {
                carrito.productos.Add(torta);
            }
            return carrito;
        }
        #endregion


        #region Propiedades
        public string NombreCliente
        {
            get
            {
                return this.nombreCliente;
            }
            set
            {
                this.nombreCliente = value;
            }
        }

        public double Total
        {
            get
            {
                return this.CalcularTotal();
            }

        }

        public int NumeroDePedido
        {
            get
            {
                return this.numeroDePedido;
            }
            set
            {
                this.numeroDePedido = value;
            }
        }
        #endregion

        #region Metodos
        
        /// <summary>
        /// Metodo que guarda un carrito en un archivo con extension .txt
        /// </summary>
        /// <param name="carrito">carrito a guardar</param>
        /// <returns>true si se guardó correctamente, caso contrario devuelve false</returns>
        public static bool Guardar(Carrito carrito)
        {
            Texto texto = null;

            try
            {
                texto = new Texto();

                texto.Guardar("Carrito", carrito.ToString());
            }
            catch (Exception)
            {
                throw;
            }

            return true;
        }

        /// <summary>
        /// Metodo que lee un carrito en un archivo con extension .txt
        /// </summary>
        /// <returns>cadena de string con los datos del carrito leido</returns>
        public static string Leer()
        {
            Texto texto = null;
            string carrito = null;

            try
            {
                texto = new Texto();
                texto.Leer("Carrito", out carrito);
            }
            catch (Exception)
            {

                throw;
            }

            return carrito;
        }
        
        /*
        /// <summary>
        /// Metodo que guarda el carrito en un archivo con extension .xml
        /// </summary>
        /// <param name="carrito">carrito a guardad</param>
        /// <returns>true si se guardó correctamente, caso contrario devuelve false</returns>
        public static bool Guardar(Carrito carrito)
        {
            Xml<Carrito> xml = new Xml<Carrito>();

            return xml.Guardar("Carrito", carrito);
        }

        /// <summary>
        /// Metodo que lee los datos de un archivo con extension .xml
        /// </summary>
        /// <returns>cadena de string con los datos del carrito leido</returns>
        public static Carrito Leer()
        {
            Xml<Carrito> xml = new Xml<Carrito>();

            xml.Leer("Carrito", out Carrito carrito);

            return carrito;
        }
        */

        /// <summary>
        /// Metodo override de ToString
        /// </summary>
        /// <returns>cadena de caracteres con los datos del carrito</returns>
        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();

            stb.AppendLine($"----------PEDIDO {this.numeroDePedido}-------------");
            stb.AppendLine($"NOMBRE CLIENTE: {this.nombreCliente}");
            stb.AppendLine($"PRODUCTO:");
            foreach (Producto producto in this.productos)
            {
                stb.AppendLine(producto.ToString());
            }

            return stb.ToString();
        }

        /// <summary>
        /// Calcula el total del carrito
        /// </summary>
        /// <returns>cero si no hay productos en el carrito, caso contrario devuelve el total que suman los productos dentro del carrito</returns>
        public double CalcularTotal()
        {
            double total = 0;

            foreach (Producto producto in this.productos)
            {
                total += producto.Precio;
            }

            return total;
        }
        #endregion
    }
}
