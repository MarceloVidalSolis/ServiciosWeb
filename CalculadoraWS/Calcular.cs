using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraWS
{
    public class Calcular
    {
        public decimal Base { get; set; }
        public decimal Altura { get; set; }
        public decimal Lado { get; set; }
        public decimal Radio { get; set; }
        public decimal Diametro { get; set; }


        public decimal ATriangulo(decimal Base,decimal Altura ) 
        {
            decimal area = (Base * Altura) / 2;
            return decimal.Round(area,2);
        }

        public decimal ACirculo(decimal Radio)
        {
            decimal pi = (decimal)Math.PI;
            decimal area = pi*(Radio * Radio);
            return decimal.Round(area,2);
        }

        public decimal ACirculo2(decimal Diametro)
        {
            decimal pi = (decimal)Math.PI;
            decimal area = pi * ((Diametro*Diametro)/4);
            return decimal.Round(area, 2);
        }

        public decimal ACuadrado(decimal Lado)
        {
            decimal area = Lado * Lado;
            return area;
        }
    }
}