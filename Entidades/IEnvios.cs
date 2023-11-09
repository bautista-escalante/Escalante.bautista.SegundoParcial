using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IEnvios
    {
        int CalcularDestino();
        double CalcularPeso();
        double CalcularPrecio(double peso, int destino);
    }
}
