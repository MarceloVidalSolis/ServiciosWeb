using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalculadoraWS
{
    /// <summary>
    /// Summary description for AreasWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AreasWebService : System.Web.Services.WebService
    {
        [WebMethod (Description ="Método que calcula area de Cuadrado")]
        public decimal AreaCuadrado(decimal Lado)
        {
            Calcular c = new Calcular();
            c.Lado = Lado;
            return c.ACuadrado(Lado);
        }

        [WebMethod(Description = "Método que calcula area de Circulo con Radio")]
        public decimal AreaCirculo(decimal Radio)
        {
            Calcular c = new Calcular();
            c.Radio = Radio;
            return c.ACirculo(Radio);
        }

        [WebMethod(Description = "Método que calcula area de Circulo con Diametro")]
        public decimal AreaCirculo2(decimal Diametro)
        {
            Calcular c = new Calcular();
            c.Diametro = Diametro;
            return c.ACirculo2(Diametro);
        }

        [WebMethod(Description = "Método que calcula area de Triangulo")]
        public decimal AreaTriangulo(decimal Base, decimal Altura)
        {
            Calcular c = new Calcular();
            c.Base = Base;
            c.Altura = Altura;
            return c.ATriangulo(Base,Altura);
        }
    }
}
