using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.CompilerServices;
using Ordico.Promos.BLL;
using Ordico.Promos.DAL.Entidades;
using Ordico.Promos.DAL.Mocks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ordico.Promos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarritoDeComprasController : ControllerBase
    {
        // GET: api/<CarritoDeComprasController>
        [HttpGet]
        public CarritoDeCompras Get()
        {
            var obj = new CarritoMock();
            var carrito=obj.ObtenerCarritoMock();
            return carrito;
        }

        // GET api/<CarritoDeComprasController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CarritoDeComprasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CarritoDeComprasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CarritoDeComprasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
