using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaLojaOOP.Entidades
{
    public class Produto
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }

        public Produto(int id, string nome, decimal preco)
        {
            if (preco <= 0)
            {
                throw new ArgumentException("O preço do produto deve ser maior que zero.");
            }

            Id = id;
            Nome = nome;
            Preco = preco;
        }
    }
}
