using Microsoft.AspNetCore.Mvc;
using Duurzame_Consumentkeuzes.Data;
using Duurzame_Consumentkeuzes.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Text;
using System.Numerics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Duurzame_Consumentkeuzes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Customer> userManager;
        public CustomersAPIController(ApplicationDbContext context, UserManager<Customer> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }
        // GET: api/<CustomersAPIController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> Get()
        {
            var customers = await _context.Users.ToListAsync();

            return customers;
        }


        // GET api/<CustomersAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomersAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomersAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomersAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
