using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaLojaOOP.Entidades
{
    public class ProdutoDigital : Produto
    {
        public string UrlDownload { get; private set; }

        public ProdutoDigital(int id, string nome, decimal preco, string urlDownload) : base(id, nome, preco)
        {
            UrlDownload = urlDownload;
        }

        public override decimal CalcularCustoEnvio()
        {
            return 0;
        }
    }
}
