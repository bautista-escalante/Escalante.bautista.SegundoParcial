using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CaracterNoNumericoException : Exception
    {
        public string Campo { get; }
        public string tipoDato { get; }
        public CaracterNoNumericoException(string nombreCampo, string tipoDato) : base($"El campo '{nombreCampo}' debe ser {tipoDato}")
        {
            this.Campo = nombreCampo;
            this.tipoDato = tipoDato;
        }
    }
}
