using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Api.Modelo;

namespace Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly _20211CTPContext _dbContext;

        public ClientesController(_20211CTPContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            return await _dbContext.Clientes.ToListAsync();
        }



    }




}
