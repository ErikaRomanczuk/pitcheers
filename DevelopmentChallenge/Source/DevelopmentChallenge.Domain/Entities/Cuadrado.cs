using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Domain.Entities
{
    /// <summary>
    /// Clase que representa la forma geometrica : Cuadrado
    /// </summary>
    public class Cuadrado : FormaGeometrica
    {
        public Cuadrado(decimal lado) : base(lado)
        {
        }

        /// <summary>
        /// Calcula el area de un cuadrado
        /// </summary>
        /// <returns>Area</returns>
        public override decimal CalcularArea()
        {
            return Lado * Lado;
        }

        /// <summary>
        /// Calcula el perimetro de un cuadrado
        /// </summary>
        /// <returns>Perimetro</returns>
        public override decimal CalcularPerimetro()
        {
            return Lado * 4;
        }
    }
}
