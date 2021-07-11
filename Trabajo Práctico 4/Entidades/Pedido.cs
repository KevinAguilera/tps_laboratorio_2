using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace Entidades
{
    /// <summary>
    /// Declaracion del delegado
    /// </summary>
    /// <param name="carrito">carrito</param>
    public delegate void Preparacion(Carrito carrito);

    public class Pedido
    {
        private static Queue<Carrito> pedidosEnPreparacion;
        private static List<Carrito> pedidosFinalizados;
        private static List<Thread> listaHilos;
        public event Preparacion PreparandoPedido;

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Pedido()
        {

        }

        /// <summary>
        /// Constructor estatico que inicializa las listas y colas
        /// </summary>
        static Pedido()
        {
            pedidosEnPreparacion = new Queue<Carrito>();
            pedidosFinalizados = new List<Carrito>();
            listaHilos = new List<Thread>();
        }
        #endregion

        #region Propiedades
        public List<Carrito> PedidosFinalizados
        {
            get
            {
                return pedidosFinalizados;
            }
        }
        public Queue<Carrito> PedidosEnPreparacion
        {
            get
            {
                return pedidosEnPreparacion;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que invoca el evento TEMA 24
        /// </summary>
        public void CarritoAceptado()
        {
            Carrito carritoAux = new Carrito();
            while ((this.PedidosEnPreparacion.Count >= 1) == true)
            {
                //espero 6 segundos
                Thread.Sleep(new Random().Next(6000, 7000));

                //elimino el pedido en preparacion y agrego el pedido a mi lista finalizada
                carritoAux = PedidosEnPreparacion.Peek();

                PedidosFinalizados.Add(carritoAux);
                PedidosEnPreparacion.Dequeue();

                //invoco a mi metodo para agregar el dato a dgv terminado
                this.PreparandoPedido.Invoke(carritoAux);
            }
        }

        /// <summary>
        /// metodo que agrega un carrito a la cola en preparacion
        /// </summary>
        /// <param name="carrito">carrito</param>
        public static void CargoPedido(Carrito carrito)
        {
            pedidosEnPreparacion.Enqueue(carrito);
        }

        /// <summary>
        /// Cierra todos los hilos abiertos
        /// </summary>
        public static void CerrarHilos()
        {
            foreach (Thread hilo in listaHilos)
            {
                hilo.Abort();
            }
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Operador que agrega un carrito al pedido, ademas inicia un hilo TEMA 23
        /// </summary>
        /// <param name="pedido">pedido</param>
        /// <param name="carrito">carrito</param>
        /// <returns></returns>
        public static Pedido operator +(Pedido pedido, Carrito carrito)
        {
            if (carrito != null)
            {
                Thread hilo = new Thread(pedido.CarritoAceptado);
                pedidosEnPreparacion.Enqueue(carrito);
                Pedido.listaHilos.Add(hilo);
                hilo.Start();
            }

            return pedido;
        }
        #endregion

    }
}
