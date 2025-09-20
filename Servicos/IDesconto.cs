using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaLojaOOP.Servicos
{
    public interface IDesconto
    {
        decimal Aplicar(decimal valorOriginal);
    }
}
