using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExceptionCampoVacio: Exception
    {
            public string Campo { get; }
            public ExceptionCampoVacio(string nombreCampo) : base($"El campo '{nombreCampo}' no puede estar vacío.")
            {
                this.Campo = nombreCampo;
            }
    }
}
