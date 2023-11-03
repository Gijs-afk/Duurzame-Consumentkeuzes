using Duurzame_Consumentkeuzes.Data;
using Duurzame_Consumentkeuzes.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using Duurzame_Consumentkeuzes.Exceptions;

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
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var currentUser = await userManager.GetUserAsync(User);

            if (currentUser != null)
            {
                bool isAdministrator = await userManager.IsInRoleAsync(currentUser, "Administrators");

                if (isAdministrator)
                {
                    var customers = await _context.Users.ToListAsync();
                    return View(customers);
                }

                return RedirectToAction("Details", new { id = currentUser.Id });
            }

            throw new NotFoundException("Gebruiker niet gevonden.");
        }

        [Authorize]
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null || _context.Users == null)
            {
                throw new NotFoundException("User not found");
            }

            var customer = await _context.Users
                .FirstOrDefaultAsync(c => c.Id == id);
            var currentUser = await userManager.GetUserAsync(User);
            bool isAdministrator = await userManager.IsInRoleAsync(currentUser, "Administrators");

            if (isAdministrator || currentUser.Id == id)
            {
                return View(customer);
            }

            return RedirectToAction("Details", new { id = currentUser.Id });

        }

        [Authorize]
        public async Task<IActionResult> Edit(string id)
        {
            var customer = await userManager.FindByIdAsync(id);
            var currentUser = await userManager.GetUserAsync(User);

            if (currentUser != null && customer != null)
            {
                bool isAdministrator = await userManager.IsInRoleAsync(currentUser, "Administrators");

                if (isAdministrator || currentUser.Id == id)
                {                   
                    return View(customer);
                }
                
                return RedirectToAction("Index");
                
            }
            
            throw new NotFoundException("Gebruiker niet gevonden.");
            
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(string id, string email, decimal budget)
        {
            var customer = await userManager.FindByIdAsync(id);
            var currentUser = await userManager.GetUserAsync(User);
            bool isAdministrator = await userManager.IsInRoleAsync(currentUser, "Administrators");

            if (customer == null | currentUser == null)
            {                     
                ModelState.AddModelError("", "User Not Found");
                throw new BadRequestException("User not found");
            }

            if (customer.Id == currentUser.Id || isAdministrator)
            {
                if (!string.IsNullOrEmpty(email))
                {
                    customer.Email = email;
                    customer.UserName = email;
                }
                // else { ModelState.AddModelError("", "Email cannot be empty"); }
                    
                customer.Budget = budget;

                if (!string.IsNullOrEmpty(email))
                {
                    IdentityResult result = await userManager.UpdateAsync(customer);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Details", new { id = currentUser.Id });
                    }

                    Errors(result);

                }

                return View(customer);
            }
            return RedirectToAction("Details", new { id = currentUser.Id });
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

                
               Errors(result);
            }
            return View("Index", userManager.Users);
        }
    }
}