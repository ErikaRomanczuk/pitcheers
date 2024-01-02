using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Domain.Entities
{
    public abstract class FormaGeometrica
    {

        public decimal Lado { get; set; }

     

        public FormaGeometrica(decimal lado)
        {
            Lado = lado;
        }

        /// <summary>
        /// Calcula el area de una forma geometrica
        /// </summary>
        /// <returns>Area</returns>
        public virtual decimal CalcularArea()
        {
            throw new ArgumentOutOfRangeException(@"No se pudo calcular el area: Forma desconocida");
        }

        /// <summary>
        /// Calcula el perimetro de una forma geometrica
        /// </summary>
        /// <returns>Perimetro</returns>
        public virtual decimal CalcularPerimetro()
        {
            throw new ArgumentOutOfRangeException(@"No se pudo calcular el perimetro: Forma desconocida");
        }
    }
}
