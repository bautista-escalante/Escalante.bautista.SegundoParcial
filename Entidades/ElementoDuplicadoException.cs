using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ElementoDuplicadoException : Exception
    {
        public string tecnologia { get; }
        public ElementoDuplicadoException(string tecnologia) : base($"este modelo de  {tecnologia} ya existe")
        {
            this.tecnologia = tecnologia;
        }
    }
}
