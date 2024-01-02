using DevelopmentChallenge.Data.Resources;
using DevelopmentChallenge.Domain.Entities;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;

namespace DevelopmentChallenge.Data.Handler
{
    public class ImprimirHandler
    {
        /// <summary>
        /// Imprime un reporte de la lista geometricas que contiene en su cuerpo un detalle por forma geometrica de cantidad, perimetro y area, y en el pie de pagina un resumen total
        /// </summary>
        /// <param name="formas"></param>
        /// <param name="idioma"></param>
        /// <returns></returns>
        public static string Imprimir(List<FormaGeometrica> formas, string idioma)
        {
            CultureInfo cultura = new CultureInfo(idioma);
            Thread.CurrentThread.CurrentCulture = cultura;
            Thread.CurrentThread.CurrentUICulture = cultura;
            cultura.NumberFormat.NumberDecimalSeparator = ",";

            ResourceManager resourceManager = new ResourceManager("DevelopmentChallenge.Data.Resources.FormaGeometricaResource", Assembly.GetExecutingAssembly());


            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append("<h1>" + FormaGeometricaResource.ListaVaciaDeFormas + "</h1>");
            }
            else
            {

                sb.Append("<h1>" + FormaGeometricaResource.ReporteDeFormas + "</h1>");

                var resultado = formas.GroupBy(f => f.GetType())
                              .Select(g => new
                              {
                                  Nombre = g.Key.Name,
                                  Cantidad = g.Count(),
                                  TotalArea = g.Sum(f => f.CalcularArea()),
                                  TotalPerimetro = g.Sum(f => f.CalcularPerimetro())
                              });

                string resultadoString = string.Join("", resultado.Select(r =>
                 ObtenerLinea(r.Cantidad, r.TotalArea, r.TotalPerimetro, r.Nombre, resourceManager, idioma)
                  ));

                sb.Append(resultadoString);


                sb.Append(FormaGeometricaResource.Total + ":<br/>");
                sb.Append(resultado.Sum(x => x.Cantidad) + " " + FormaGeometricaResource.Formas + " ");
                sb.Append(FormaGeometricaResource.Perimetro + " " + resultado.Sum(x => x.TotalPerimetro).ToString("#.##") + " ");
                sb.Append(FormaGeometricaResource.Area + " " + (resultado.Sum(x => x.TotalArea)).ToString("#.##"));
            }

            return sb.ToString();
        }


        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string tipo, ResourceManager resourceManager, string idioma)
        {
            if (cantidad > 0)
            {

                string forma = cantidad > 1 ?
                    resourceManager.GetString(tipo + "s") :
                    resourceManager.GetString(tipo);

                var resultado = $"{cantidad} "
                         + forma + " | "
                         + FormaGeometricaResource.Area + $" {area:#.##} | "
                         + FormaGeometricaResource.Perimetro + $" {perimetro:#.##} <br/>";

                return resultado;
            }

            return string.Empty;
        }

    }
}
