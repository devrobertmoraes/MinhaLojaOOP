using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaLojaOOP.Servicos
{
    public class DescontoPorCupom : IDesconto
    {
        private readonly string _cupom;

        public DescontoPorCupom(string cupom)
        {
            _cupom = cupom;
        }

        public decimal Aplicar(decimal valorOriginal)
        {
            if (_cupom.ToUpper() == "PROMO15")
            {
                return valorOriginal * 0.15m;
            }

            return 0;
        }
    }
}
