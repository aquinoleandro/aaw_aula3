using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pedidos.API.Models;

namespace Pedidos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public static Dictionary<int, Pedido> mpPedidos = new Dictionary<int, Pedido>();

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Pedido>> Get()
        {
            return mpPedidos.Values;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Pedido> Get(int id)
        {
            return mpPedidos[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Pedido ped)
        {
            mpPedidos.Add(ped.id, ped);

        }

        // PUT api/values/5
        [HttpPut()]
        public void Put([FromBody] Pedido ped)
        {
            mpPedidos[ped.id] = ped;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mpPedidos.Remove(id);
        }
    }
}
