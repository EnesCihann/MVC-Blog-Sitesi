using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Blog_Sitesi.Entites;
using MVC_Blog_Sitesi.Models;
using MVC_Blog_Sitesi.Repository;
using System;
using System.Threading.Tasks;

namespace MVC_Blog_Sitesi.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IArticleRepository<Article> articleRepository;

        public UserController(UserManager<AppUser> userManager,IArticleRepository<Article> articleRepository)
        {
            this.userManager = userManager;
            this.articleRepository = articleRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserVM userVM)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser();
                appUser.UserName = userVM.FirstName;
                appUser.Email=userVM.Email;
                appUser.FirstName=userVM.FirstName;
                appUser.LastName=userVM.LastName;
                appUser.Description=userVM.Description;

               IdentityResult result=await userManager.CreateAsync(appUser,userVM.Password);

                if(result.Succeeded)
                    return RedirectToAction("Login", "Account");
                else
                {
                    Errors(result);
                }
                
            }

            return View(userVM);
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("User Operations", $"{error.Code}-{error.Description}");
            }
        }
    }
}
