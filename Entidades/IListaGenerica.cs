using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IListaGenerica<T>
    {
        public List<Carrito<Tecnologia>>? Ordenar(bool ascendente = true);
        public void AgregarDato(Tecnologia tec);
        public void ActializarDato(int precio);
    }
}
