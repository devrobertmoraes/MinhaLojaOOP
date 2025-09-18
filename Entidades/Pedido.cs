using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaLojaOOP.Entidades
{
    public class Pedido
    {
        public int Id { get; private set; }
        public Cliente Cliente { get; private set; }
        public DateTime DataDoPedido { get; private set; }
        public decimal ValorTotal { get; private set; }

        private readonly List<ItemDoPedido> _itens = new List<ItemDoPedido>();
        public IReadOnlyCollection<ItemDoPedido> Itens => _itens.AsReadOnly();

        public Pedido(int id, Cliente cliente)
        {
            Id = id;
            Cliente = cliente;
            DataDoPedido = DateTime.Now;
        }

        public void AdicionarItem(Produto produto, int quantidade)
        {
            if (_itens.Any(item => item.Produto.Id == produto.Id))
            {
                Console.WriteLine($"O produto '{produto.Nome}' já está no pedido.");
                return;
            }

            var novoItem = new ItemDoPedido(produto, quantidade);
            _itens.Add(novoItem);

            CalcularValorTotal();
        }

        private void CalcularValorTotal()
        {
            ValorTotal = _itens.Sum(item => item.Subtotal);
        }
    }
}
