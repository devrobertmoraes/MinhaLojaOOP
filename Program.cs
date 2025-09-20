using MinhaLojaOOP.Apresentacao;
using MinhaLojaOOP.Entidades;

namespace MinhaLojaOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Sistema...");

            try
            {
                var cliente = new Cliente(1, "João Silva", "joao@email.com");
                var produto1 = new ProdutoFisico(101, "Teclado Mecânico", 350.50m, 1.2m);
                var produto2 = new ProdutoFisico(102, "Mouse Gamer", 120.00m, 0.3m);
                var produto3 = new ProdutoDigital(201, "Monitor 27 polegadas", 1850.00m, "http://...");

                var pedido1 = new Pedido(cliente);

                Console.WriteLine("\nProcessando primeiro pedido...");
                pedido1.AdicionarItem(produto1, 1);
                pedido1.AdicionarItem(produto2, 2);
                FormatadorDeExibicao.ExibirDetalhesDoPedido(pedido1);

                Console.WriteLine("\nProcessando segundo pedido...");
                var pedido2 = new Pedido(cliente);
                pedido2.AdicionarItem(produto3, 1);
                FormatadorDeExibicao.ExibirDetalhesDoPedido(pedido2);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro ao processar o pedido: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nSistema finalizado.");
            }
        }
    }
}
