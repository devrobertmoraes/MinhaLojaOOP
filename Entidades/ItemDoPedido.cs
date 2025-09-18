using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaLojaOOP.Entidades
{
    public class ItemDoPedido
    {
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
        public decimal PrecoUnitario { get; private set; }
        public decimal Subtotal
        {
            get { return Quantidade * PrecoUnitario;  }
        }

        public ItemDoPedido(Produto produto, int quantidade)
        {
            if (quantidade <= 0)
            {
                throw new ArgumentException("A quantidade deve ser maior que zero.");
            }

            Produto = produto;
            Quantidade = quantidade;
            PrecoUnitario = produto.Preco;
        }
    }
}
