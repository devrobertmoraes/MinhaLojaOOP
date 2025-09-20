using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaLojaOOP.Entidades
{
    public class Pedido
    {
        private static int _proximoNumeroSequencial = 1;

        public string Id { get; private set; }
        public Cliente Cliente { get; private set; }
        public DateTime DataDoPedido { get; private set; }
        public decimal ValorItens { get; private set; }
        public decimal CustoEnvio { get; private set; }
        public decimal ValorTotal { get; private set; }

        private readonly List<ItemDoPedido> _itens = new List<ItemDoPedido>();
        public IReadOnlyCollection<ItemDoPedido> Itens => _itens.AsReadOnly();

        public Pedido(Cliente cliente)
        {
            Id = GerarNovoId();
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

            CalcularTotais();
        }

        private void CalcularTotais()
        {
            ValorItens = _itens.Sum(item => item.Subtotal);

            CustoEnvio = _itens.Sum(item => item.Produto.CalcularCustoEnvio() * item.Quantidade);

            ValorTotal = ValorItens + CustoEnvio;
        }

        private static string GerarNovoId()
        {
            string ano = DateTime.Now.Year.ToString();
            string sequencial = _proximoNumeroSequencial.ToString("D4");
            _proximoNumeroSequencial++;
            return $"ORD-{ano}-{sequencial}";
        }
    }
}
