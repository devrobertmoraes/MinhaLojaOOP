using MinhaLojaOOP.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaLojaOOP.Apresentacao
{
    public class FormatadorDeExibicao
    {
        public static void ExibirDetalhesDoPedido(Pedido pedido)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Detalhes do Pedido Nº: {pedido.Id}");
            Console.WriteLine($"Data: {pedido.DataDoPedido:dd/MM/yyyy HH:mm:ss}");
            Console.WriteLine($"Cliente: {pedido.Cliente.Nome} ({pedido.Cliente.Email})");
            Console.WriteLine($"Endereço de Entrega: {pedido.EnderecoDeEntrega.Logradouro}, {pedido.EnderecoDeEntrega.Numero} - {pedido.EnderecoDeEntrega.Cidade}/{pedido.EnderecoDeEntrega.Estado} - CEP: {pedido.EnderecoDeEntrega.Cep}");
            Console.WriteLine("Itens:");
            if (pedido.Itens.Count == 0)
            {
                Console.WriteLine("- Pedido vazio.");
            }
            else
            {
                foreach (var item in pedido.Itens)
                {
                    Console.WriteLine($"- {item.Produto.Nome} | Qtd: {item.Quantidade} | Preço Unit.: R$ {item.PrecoUnitario:F2} | Subtotal: R$ {item.Subtotal:F2}");

                    if (item.Produto is ProdutoFisico produtoFisico)
                    {
                        Console.Write($" (Peso: {produtoFisico.PesoEmKg}kg)");
                    }

                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Subtotal dos Itens: R$ {pedido.ValorItens:F2}");
            Console.WriteLine($"Custo de Envio: R$ {pedido.CustoEnvio:F2}");
            Console.WriteLine($"Total em Descontos: R$ {pedido.ValorDescontos:F2}");
            Console.WriteLine($"VALOR TOTAL DO PEDIDO: R$ {pedido.ValorTotal:F2}");
            Console.WriteLine("------------------------------------------");
        }
    }
}
