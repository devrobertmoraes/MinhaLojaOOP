using MinhaLojaOOP.Entidades;

namespace MinhaLojaOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando processamento de pedido...");

            try
            {
                var cliente = new Cliente(1, "João Silva", "joao@email.com");
                var produto1 = new Produto(101, "Teclado Mecânico", 350.50m);
                var produto2 = new Produto(102, "Mouse Gamer", 120.00m);

                var pedido = new Pedido(1, cliente);

                pedido.AdicionarItem(produto1, 1);
                pedido.AdicionarItem(produto2, 2);

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
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro ao processar o pedido: {ex.Message}");
            }
        }
    }
}
