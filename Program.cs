using MinhaLojaOOP.Entidades;

namespace MinhaLojaOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando processamento de pedido...");

            var cliente = new Cliente { Id = 1, Nome = "João Silva", Email = "joao@email.com" };
            var produto1 = new Produto { Id = 101, Nome = "Teclado Mecânico", Preco = 350.50m };
            var produto2 = new Produto { Id = 102, Nome = "Mouse Gamer", Preco = 120.00m };

            // criacao do pedido
            var pedido = new Pedido
            {
                Id = 1,
                Cliente = cliente,
                DataDoPedido = DateTime.Now,
                Itens = new List<ItemDoPedido>()
            };

            // inserção de ítens no pedido
            var item1 = new ItemDoPedido { Produto = produto1, Quantidade = 1, PrecoUnitario = produto1.Preco };
            var item2 = new ItemDoPedido { Produto = produto2, Quantidade = 2, PrecoUnitario = produto2.Preco };
            pedido.Itens.Add(item1);
            pedido.Itens.Add(item2);

            // calcular total do pedido
            decimal total = 0;

            foreach (var item in pedido.Itens)
            {
                total += item.PrecoUnitario * item.Quantidade;
            }

            pedido.ValorTotal = total;

            // exibição do resultado
            Console.WriteLine($"Pedido Nº: {pedido.Id}");
            Console.WriteLine($"Cliente: {pedido.Cliente.Nome}");
            Console.WriteLine("Itens:");
            foreach (var item in pedido.Itens)
            {
                Console.WriteLine($"- {item.Produto.Nome} | Qtd: {item.Quantidade} | Preço Unit.: R$ {item.PrecoUnitario}");
            }
            Console.WriteLine($"Valor Total do Pedido: R$ {pedido.ValorTotal}");

            Console.WriteLine("Processamento finalizado.");
        }
    }
}
