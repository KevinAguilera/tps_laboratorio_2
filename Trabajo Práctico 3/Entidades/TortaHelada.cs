using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;


namespace Entidades
{
    public class TortaHelada : Producto
    {
        public enum Tamanio
        {
            Individual,
            Entero
        }

        private Tamanio tamanioElegido;
        private static Producto.Tipo tipo;

        #region Constructores
        /// <summary>
        /// Constructor estatico que agrega el tipo Torta al tipo
        /// </summary>
        static TortaHelada()
        {
            tipo = Producto.Tipo.Torta;
        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public TortaHelada()
        {

        }

        /// <summary>
        /// Constructor que obtiene el tamaño y lista de gustos
        /// </summary>
        /// <param name="tamanio">tamaño</param>
        /// <param name="gustos">gustos</param>
        public TortaHelada(Tamanio tamanio, List<Producto.GustoHelado> gustos) : base(gustos)
        {
            this.tamanioElegido = tamanio;
            this.Precio = this.CalcularPrecio();
        }
        #endregion

        #region Propiedades
        public Tamanio TamanioElegido
        {
            get
            {
                return this.tamanioElegido;
            }
            set
            {
                this.tamanioElegido = value;
            }
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Operador que agrega un gusto de helado a una torta
        /// </summary>
        /// <param name="p">torta</param>
        /// <param name="gusto">gusto</param>
        /// <returns>torta</returns>
        public static TortaHelada operator +(TortaHelada p, GustoHelado gusto)
        {
            int maximo = 3;

            if (p.SaboresDeHelado.Count() < maximo)
            {
                p.SaboresDeHelado.Add(gusto);
            }
            else
            {
                throw new GustosException();
            }
            return p;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Calcula el monto de la torta elegida
        /// </summary>
        /// <returns>precio de la torta</returns>
        public override double CalcularPrecio()
        {
            double precio = 0;
            switch (this.tamanioElegido)
            {
                case Tamanio.Individual:
                    precio = 120;
                    break;
                case Tamanio.Entero:
                    precio = 400;
                    break;
                default:
                    break;
            }
            return precio;
        }

        /// <summary>
        /// Metodo override toString
        /// </summary>
        /// <returns>cadena de caracteres con los datos de la torta</returns>
        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine($"{tipo} TAMAÑO: {this.tamanioElegido}");
            stb.AppendLine(base.ToString());
            return stb.ToString();
        }
        #endregion
    }
}
