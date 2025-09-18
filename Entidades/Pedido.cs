using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaLojaOOP.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataDoPedido { get; set; }
        public List<ItemDoPedido> Itens { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
