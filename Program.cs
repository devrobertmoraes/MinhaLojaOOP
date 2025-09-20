using MinhaLojaOOP.Apresentacao;
using MinhaLojaOOP.Entidades;
using MinhaLojaOOP.Servicos;

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
                var produtoFisico = new ProdutoFisico(101, "Teclado Mecânico", 350.50m, 1.2m);
                var produtoDigital = new ProdutoDigital(201, "Monitor 27 polegadas", 1850.00m, "http://...");

                Console.WriteLine("\nProcessando pedido com descontos...");

                var pedido = new Pedido(cliente);
                pedido.AdicionarItem(produtoFisico, 1);
                pedido.AdicionarItem(produtoDigital, 2);

                var politicaDeDesconto1 = new DescontoPrimeiraCompra();
                var politicaDeDesconto2 = new DescontoPorCupom("PROMO15");
                var politicaDeDesconto3 = new DescontoPorCupom("CUPOMINVALIDO");

                pedido.AdicionarDesconto(politicaDeDesconto1);
                pedido.AdicionarDesconto(politicaDeDesconto2);
                pedido.AdicionarDesconto(politicaDeDesconto3);

                FormatadorDeExibicao.ExibirDetalhesDoPedido(pedido);
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
