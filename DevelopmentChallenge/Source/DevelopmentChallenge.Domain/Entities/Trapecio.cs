using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Domain.Entities
{
    /// <summary>
    ///Clase que representa la forma geometrica :  Trapecio. Un trapecio es necesariamente un cuadrilátero convexo en geometría euclídea
    /// </summary>
    public class Trapecio : FormaGeometrica
    {
        /// <summary>
        /// Lado parlelo mayor de la base del trapecio
        /// </summary>
        public decimal BaseMayor { get; set; }

        /// <summary>
        /// Lado parlelo menor de la base del trapecio
        /// </summary>
        public decimal BaseMenor { get; set; }

        /// <summary>
        /// Lado lateral o cateto 
        /// </summary>
        public decimal Lado1 { get; set; }

        /// <summary>
        /// Lado lateral o cateto 
        /// </summary>
        public decimal Lado2 { get; set; }


        public Trapecio(decimal baseMayor, decimal baseMenor, decimal lado1, decimal lado2) : base(0) // No se usa el lado para la inicialización
        {
            BaseMayor = baseMayor;
            BaseMenor = baseMenor;
            Lado1 = lado1;
            Lado2 = lado2;
        }


        public override decimal CalcularArea()
        {
            return (decimal)0.5 * (BaseMayor + BaseMenor) * Lado1;
        }

        public override decimal CalcularPerimetro()
        {
            return BaseMayor + BaseMenor + Lado1 + Lado2;
        }
    }
}
