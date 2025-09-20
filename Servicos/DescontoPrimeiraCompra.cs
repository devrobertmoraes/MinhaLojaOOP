using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaLojaOOP.Servicos
{
    public class DescontoPrimeiraCompra : IDesconto
    {
        public decimal Aplicar(decimal valorOriginal)
        {
            return valorOriginal * 0.10m;
        }
    }
}
