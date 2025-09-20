using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaLojaOOP.Entidades
{
    public class ProdutoFisico : Produto
    {
        public decimal PesoEmKg { get; private set; }

        public ProdutoFisico(int id, string nome, decimal preco, decimal pesoEmKg) : base(id, nome, preco) 
        {
            PesoEmKg = pesoEmKg;
        }

        public override decimal CalcularCustoEnvio()
        {
            return PesoEmKg * 5.0m;
        }
    }
}
