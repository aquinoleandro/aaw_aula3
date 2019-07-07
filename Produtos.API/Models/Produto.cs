using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos.API.Models
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public double preco { get; set; }

        public Produto(int id, string nome, double preco)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
        }
    }
}
