using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Domain.Entities
{
    /// <summary>
    ///  Clase que representa la forma geometrica : Rectangulo. Un rectángulo es un paralelogramo cuyos cuatro lados forman ángulos rectos entre sí. Los lados opuestos tienen la misma longitud
    /// </summary>
   public class Rectangulo : FormaGeometrica
    {
        /// <summary>
        /// Base/ancho del rectangulo
        /// </summary>
        public decimal Base { get; set; }
        public Rectangulo(decimal lado, decimal baseRectangulo) : base(lado)
        {
            Base = baseRectangulo;
        }

        /// <summary>
        /// Calcula el area de un rectangulo
        /// </summary>
        /// <returns>Area</returns>
        public override decimal CalcularArea()
        {
            return Lado * Base;
        }

        /// <summary>
        /// Calcula el perimetro de un rectangulo
        /// </summary>
        /// <returns>Perimetro</returns>
        public override decimal CalcularPerimetro()
        {
            return 2 * (Lado + Base);
        }
    }
}
