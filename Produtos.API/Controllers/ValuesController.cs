using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Produtos.API.Models;

namespace Produtos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public string[] dados = { "Casa", "Carro"};
        public List<String> lsDados = new List<String>();
        public static Dictionary<int, Produto> mpDados = new Dictionary<int, Produto>();
       
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            return mpDados.Values;
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Produto> Get(int id)
        {
            return mpDados[id];
        }

        // POST api/values
        [HttpPost]
        //  public void Post([FromBody] int id, string nome, double preco)
        public void Post([FromBody] Produto prod)
        {
            mpDados.Add(prod.id, prod);
        }

        // PUT api/values/5
        //[HttpPut("{id}")]
        [HttpPut]
        public void Put([FromBody] Produto produto)
        {
            mpDados[produto.id] = produto;

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mpDados.Remove(id);
        }
    }
}
