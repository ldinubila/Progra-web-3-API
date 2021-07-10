using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Api.Modelo;

namespace Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {

        private readonly _20211CTPContext _dbContext;

        public PedidosController(_20211CTPContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pedido>> GetPedido(int id)
        {
            var pedido = await _dbContext.Pedidos.FindAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }

            return pedido;
        }
    }
}
