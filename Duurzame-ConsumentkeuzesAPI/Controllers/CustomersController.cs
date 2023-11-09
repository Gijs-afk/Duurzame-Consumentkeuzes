using Duurzame_Consumentkeuzes.Data;
using Duurzame_Consumentkeuzes.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Duurzame_ConsumentkeuzesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Customer> userManager;
        public CustomersController(ApplicationDbContext context, UserManager<Customer> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }
        // GET: api/<CustomersController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> Get()
        {
            var customers = await _context.Users.ToListAsync();

            return customers;
        }

        // GET api/<CustomersController>/5
        [HttpGet("{email}")]
        public async Task<ActionResult<Customer>> Get(string email)
        {
            var customer = await _context.Users.FirstOrDefaultAsync(p => p.Email == email);
            if (customer == null)
            {
                return NotFound();
            }
            return customer;
        }

        // POST api/<CustomersController>
        [HttpPost]
        public async Task<ActionResult<Customer>> Post([FromBody] string email)
        {
            if (emailValid(email))
            {
                var newCustomer = new Customer
                {
                    Email = email,
                    UserName = email,
                };

                await userManager.CreateAsync(newCustomer, "Pa$$w0rd");
                await _context.SaveChangesAsync();

                return newCustomer;
            }
            else
            {
                ModelState.AddModelError("Email", "Ongeldig email formaat.");
                return BadRequest(ModelState);
            }
        }

        // Valideren of het ingevoerde emailadres van het juiste formaat is.
        private bool emailValid(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // PUT api/<CustomersController>/5
        // Emailadres wijzigen
        [HttpPut("{email}")]
        public async Task<ActionResult<Customer>> Put(string email, [FromBody] string newEmail)
        {
            var customer = await _context.Users.FirstOrDefaultAsync(p => p.Email == email);
            if (customer == null)
            {
                return NotFound();
            }

            if (emailValid(newEmail))
            {
                customer.Email = newEmail;
                customer.UserName = newEmail;
                customer.NormalizedEmail = newEmail.ToUpper();
                customer.NormalizedUserName = newEmail.ToUpper();
                _context.Update(customer);
                await _context.SaveChangesAsync();

                return customer;
            }
            else
            {
                ModelState.AddModelError("Email", "Ongeldig email formaat.");
                return BadRequest(ModelState);
            }
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{email}")]
        public async Task<ActionResult<Customer>> Delete(string email)
        {
            var customer = await _context.Users.FirstOrDefaultAsync(p => p.Email == email);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Remove(customer);
            await _context.SaveChangesAsync();

            var deletedPlayer = await _context.Users.FirstOrDefaultAsync(p => p.Email == email);
            if (deletedPlayer == null)
            {
                return Ok();
            }

            else
            {
                return BadRequest();
            }

        }
    }
}
