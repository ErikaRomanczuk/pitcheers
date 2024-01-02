using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Domain.Entities
{
    /// <summary>
    /// Clase que representa la forma geometrica : Circulo. Un círculo es una figura plana formada por una CIRCUNFERENCIA y su interior. Un círculo es una figura muy especial. Veamos porqué. La línea curva que conforma el contorno de un círculo es una CIRCUNFERENCIA, que es una línea curva cerrada en la que todos sus puntos están a la misma distancia de su centro
    /// </summary>
    public class Circulo : FormaGeometrica
    {
        public Circulo(decimal lado) : base(lado)
        {
            
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (this.Lado / 2) * (this.Lado / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * this.Lado;
        }
    }
}
