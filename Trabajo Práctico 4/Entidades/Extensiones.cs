using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extensiones
    {
        /// <summary>
        /// Extension que devuelve la cantidad maxima de gustos para un tamaño de helado
        /// </summary>
        /// <param name="tamanio">tamaño del helado a evaluar</param>
        /// <returns>la cantidad maxima de gustos</returns>
        public static int CantidadDeGustosPermitidos(this Helado.Tamanio tamanio)
        {
            int cantidad = 0;

            switch (tamanio)
            {
                case Helado.Tamanio.Pote20Kilos:
                    cantidad = 2;
                    break;
                case Helado.Tamanio.Pote30Kilos:
                case Helado.Tamanio.Pote45Kilos:
                    cantidad = 3;
                    break;
                case Helado.Tamanio.Pote60Kilos:
                    cantidad = 4;
                    break;
                default:
                    break;
            }

            return cantidad;
        }

        /// <summary>
        /// Extension que devuelve la cantidad maxima de gustos para un tamaño de Torta
        /// </summary>
        /// <param name="tamanio">tamaño de la torta a evaluar</param>
        /// <returns>la cantidad maxima de gustos</returns>
        public static int CantidadDeGustosPermitidos(this TortaHelada.Tamanio tamanio)
        {
            int cantidad = 0;
            switch (tamanio)
            {
                case TortaHelada.Tamanio.Individual:
                    cantidad = 1;
                    break;
                case TortaHelada.Tamanio.Entero:
                    cantidad = 2;
                    break;
                default:
                    break;
            }

            return cantidad;
        }

    }
}
