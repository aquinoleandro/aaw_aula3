using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pedidos.API.Models;

namespace Pedidos.API.Models
{
    public class Pedido
    {
        public int id { get; set; }
        public Produto produto { get; set; }

    }
}
