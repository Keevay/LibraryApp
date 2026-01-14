using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        // We inject the UserManager service here
        public UsersController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        // GET: /Users
        public async Task<IActionResult> Index()
        {
            // Fetch all users from the database
            var users = await _userManager.Users.ToListAsync();
            return View(users);
        }

        // POST Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id)
        {
            // 1. Find the user
            var user = await _userManager.FindByIdAsync(id);

            // 2. Delete the user if found
            if (user != null)
            {
                // Optional: Prevent deleting yourself
                if (user.UserName == User.Identity.Name)
                {
                    TempData["Error"] = "You cannot delete your own admin account!";
                    return RedirectToAction(nameof(Index));
                }

                await _userManager.DeleteAsync(user);
            }

            return RedirectToAction(nameof(Index));
        }
    }
    
    
}