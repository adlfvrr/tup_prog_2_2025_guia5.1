using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ej1.Models
{
    internal class PatenteRegex:IPatentes
    {
        public string Patente { get; private set; }
        public PatenteRegex(string patente) { this.Patente = patente; }
        public int DeterminarTipo()
        {
            int tipo = -1;
            //patrones
            string patronHasta2016 = @"^[A-Z]{3}\d{3}$";
            string patronDesde2016 = @"^[A-Z]{2}\d{3}[A-Z]{2}$";
            string patronMoto = @"^[A-Z]{2}\d{3}[A-Z]{3}$";
            string patronAcoplado = @"^[A-Z]{2}\d{4}$";
            string cadena = this.Patente.Replace(" ","").ToUpper();
            if (Regex.Match(cadena, patronHasta2016).Success){ tipo = 0; }
            else if(Regex.Match(cadena,patronDesde2016).Success){ tipo = 1; }
            else if(Regex.Match(cadena,patronMoto).Success){ tipo = 2; }
            else if(Regex.Match(cadena,patronAcoplado).Success){ tipo = 3; }
            return tipo;
        }
    }
}
