using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Blog_Sitesi.Entites;
using MVC_Blog_Sitesi.Models;
using System.Threading.Tasks;

namespace MVC_Blog_Sitesi.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public AccountController(UserManager<AppUser>userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Login(string returnUrl)
        {
            LoginVM loginVM = new LoginVM();
            loginVM.ReturnUrl = returnUrl;
            return View(loginVM);
        }
        [HttpPost]
        public async Task<IActionResult>Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = await userManager.FindByEmailAsync(loginVM.Email);
                if (appUser != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(appUser, loginVM.Password,false,false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction ("Index", "Home");
                    }
                    else
                    {
                        ViewBag.Message = "Kullanıcı bilgileri eşleşmedi!";
                    }
                }

            }
            return View(loginVM);
        }

        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
