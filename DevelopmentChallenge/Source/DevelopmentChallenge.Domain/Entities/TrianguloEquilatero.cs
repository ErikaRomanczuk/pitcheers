using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Domain.Entities
{
    /// <summary>
    ///Clase que representa la forma geometrica :  Triangulo Equilatero. Un triángulo equilátero es un polígono regular, es decir, tiene sus tres lados iguales.
    /// </summary>
    public class TrianguloEquilatero : FormaGeometrica
    {
        public TrianguloEquilatero(decimal lado) : base(lado)
        {
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return Lado * 3;
        }

    }
}
