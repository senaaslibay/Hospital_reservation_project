using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Transactions;
using Y225012150.Models;

namespace Y225012150.Controllers
{
    public class RoleController : Controller
    {
        private HastaneRandevuContext context = new HastaneRandevuContext();
        private RoleManager<IdentityRole> roleManager;
        private UserManager<UserDetails> userManager;
        public RoleController(RoleManager<IdentityRole> roleMgr)
        {
            roleManager = roleMgr;
        }

        private bool Auth(string userId)
        {
            UserDetails userObject = context.Users.FirstOrDefault(x=> x.Id == userId);
            if (userObject.RollerID != 1)
            {
                return false;
            }
            return true;
        }
        public IActionResult Index()
        {
            string userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!this.Auth(userId))
            {
                return RedirectToAction("Errors");
            }
            List<Roller> roles = context.Roller.ToList();
            return View(roles);
        }
        public IActionResult Errors()
        {
            return View();
        }
        public IActionResult Create() 
        {
            string userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!this.Auth(userId))
            {
                return RedirectToAction("Errors");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Required] string name)
        {
            string userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!this.Auth(userId))
            {
                return RedirectToAction("Errors");
            }
            if (ModelState.IsValid)
            {
                Roller role = new Roller() { RoleAdi = name };
                context.Roller.Add(role);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(name);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            string userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!this.Auth(userId))
            {
                return RedirectToAction("Errors");
            }
            if (id == null || context.Roller == null)
            {
                return NotFound();
            }
            var role = await context.Roller.FindAsync(id);
            if (role != null)
            {
                context.Roller.Remove(role);
            }

            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


       
        public IActionResult AssignUserToRole()
        {
            string userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!this.Auth(userId))
            {
                return RedirectToAction("Errors");
            }
            List<UserDetails> users= context.Users.ToList();

            return View(users);
        }


        [HttpPost]
        public async Task<IActionResult> AssignUserToRole(string userId, string role)
        {
            string current_userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!this.Auth(current_userId))
            {
                return RedirectToAction("Errors");
            }

            UserDetails? user = context.Users.Find(userId);
            user.Roller = context.Roller.FirstOrDefault(x => x.RoleAdi == role);//new Roller() { RoleAdi = role };
            
            await context.SaveChangesAsync();
            List<UserDetails> users = context.Users.ToList();


            return View(users);
        }

    }
}
