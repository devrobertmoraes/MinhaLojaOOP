using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaLojaOOP.Entidades
{
    public record Endereco(string Logradouro, string Numero, string Cidade, string Estado, string Cep);
}
