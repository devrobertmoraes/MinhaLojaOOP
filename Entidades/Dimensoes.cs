using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaLojaOOP.Entidades
{
    public readonly struct Dimensoes
    {
        public decimal AlturaCm { get; }
        public decimal LarguraCm { get; }
        public decimal ProfundidadeCm { get; }

        public Dimensoes(decimal alturaCm, decimal larguraCm, decimal profundidadeCm)
        {
            AlturaCm = alturaCm;
            LarguraCm = larguraCm;
            ProfundidadeCm = profundidadeCm;
        }
    }
}
