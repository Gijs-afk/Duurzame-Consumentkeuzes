using Duurzame_Consumentkeuzes.Data;
using Duurzame_Consumentkeuzes.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace Duurzame_Consumentkeuzes.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Customer> userManager;
        public CustomersController(ApplicationDbContext context, UserManager<Customer> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var customers = await _context.Users
                .ToListAsync();

            return View(customers);
        }
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var customer = await _context.Users
                .FirstOrDefaultAsync(c => c.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        [Authorize(Roles = "Administrators")]
        public async Task<IActionResult> Edit(string id)
        {
            var customer = await userManager.FindByIdAsync(id);

            if (customer != null)
                return View(customer);
            else
                return RedirectToAction("Index");
        }

        [Authorize(Roles = "Administrators")]
        [HttpPost]
        public async Task<IActionResult> Edit(string id, string email, decimal budget)
        {
            var customer = await userManager.FindByIdAsync(id);
            if (customer != null)
            {
                if (!string.IsNullOrEmpty(email))
                {
                    customer.Email = email;
                    customer.UserName = email;
                }
                else
                    ModelState.AddModelError("", "Email cannot be empty");

                customer.Budget = budget;

                if (!string.IsNullOrEmpty(email))
                {
                    IdentityResult result = await userManager.UpdateAsync(customer);
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                    else
                        Errors(result);
                }
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return View(customer);
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }

        [Authorize(Roles = "Administrators")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || userManager.Users == null)
            {
                return NotFound();
            }

            var customer = await userManager.FindByIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            return View("Delete", customer);
        }

        [Authorize(Roles = "Administrators")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var customer = await userManager.FindByIdAsync(id);
            if (userManager.Users == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Users'  is null.");
            }

            if (customer != null)
            {
                _context.Users.Remove(customer);
                await _context.SaveChangesAsync();
                IdentityResult result = await userManager.DeleteAsync(customer);
                if (result.Succeeded)

                    return RedirectToAction(nameof(Index));

                else
                    Errors(result);
            }
            return View("Index", userManager.Users);
        }
    }
}