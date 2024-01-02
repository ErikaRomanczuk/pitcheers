using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Handler;
using DevelopmentChallenge.Domain.Entities;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {

        #region Idiomas

        private const string _castellano = "es-ES";
        private const string _ingles = "en-US";
        private const string _italiano = "it-IT";

        #endregion

        [TestCase]
        public void TestResumenListaVacia()
        {
            var resultado = ImprimirHandler.Imprimir(new List<FormaGeometrica>(), _castellano);
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", resultado);
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            var resultado = ImprimirHandler.Imprimir(new List<FormaGeometrica>(), _ingles);

            Assert.AreEqual("<h1>Empty list of shapes!</h1>", resultado);
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = ImprimirHandler.Imprimir(cuadrados, _castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);

        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado( 5),
                new Cuadrado( 1),
                new Cuadrado( 3)
            };

            var resumen = ImprimirHandler.Imprimir(cuadrados, _ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado( 5),
                new Circulo( 3),
                new TrianguloEquilatero( 4),
                new Cuadrado( 2),
                new TrianguloEquilatero( 9),
                new Circulo( 2.75m),
                new TrianguloEquilatero( 4.2m)
            };

            var resumen = ImprimirHandler.Imprimir(formas, _ingles);

            Assert.AreEqual(
                           "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                           resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado( 5),
                new Circulo( 3),
                new TrianguloEquilatero( 4),
                new Cuadrado( 2),
                new TrianguloEquilatero( 9),
                new Circulo( 2.75m),
                new TrianguloEquilatero( 4.2m)
            };

            var resumen = ImprimirHandler.Imprimir(formas, _castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }
      
        #region Test Adicionales para el idioma Italiano
    
        [TestCase]
        public void TestResumenListaVaciaItaliano()
        {
            var resultado = ImprimirHandler.Imprimir(new List<FormaGeometrica>(), _italiano);
            Assert.AreEqual("<h1>Lista vuota di forme!</h1>", resultado);
        }


        [TestCase]
        public void TestResumenListaConUnTrianguloItaliano()
        {
            var triangulo = new List<FormaGeometrica> { new TrianguloEquilatero(9) };

            var resumen = ImprimirHandler.Imprimir(triangulo, _italiano);

            Assert.AreEqual("<h1>Rapporto sulle forme</h1>1 Triangolo | Area 35,07 | Perimetro 27 <br/>TOTALE:<br/>1 forme Perimetro 27 Area 35,07", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTraprecioItaliano()
        {
            var trapecio = new List<FormaGeometrica> { new Trapecio(6,4,5,6) };

            var resumen = ImprimirHandler.Imprimir(trapecio, _italiano);

            Assert.AreEqual("<h1>Rapporto sulle forme</h1>1 Trapezio | Area 25 | Perimetro 21 <br/>TOTALE:<br/>1 forme Perimetro 21 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(2),
                new Circulo(4),
                new TrianguloEquilatero(3),
                new Rectangulo(2,4),
                 new Trapecio(6,4,5,6),
                new Cuadrado(1),
                new TrianguloEquilatero(2),
                new Circulo(4.5m),
                new TrianguloEquilatero(3.8m),
                new Rectangulo(3,5)

            };

            var resumen = ImprimirHandler.Imprimir(formas, _italiano);

            Assert.AreEqual(
                $"<h1>Rapporto sulle forme</h1>2 Quadrati | Area 5 | Perimetro 12 <br/>2 Cerchi | Area 28,47 | Perimetro 26,7 <br/>3 Triangoli | Area 11,88 | Perimetro 26,4 <br/>2 Rettangoli | Area 23 | Perimetro 28 <br/>1 Trapezio | Area 25 | Perimetro 21 <br/>TOTALE:<br/>10 forme Perimetro 114,1 Area 93,35",
                resumen);
        }
        #endregion
    }
}
