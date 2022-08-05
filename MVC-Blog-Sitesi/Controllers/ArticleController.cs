using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Blog_Sitesi.Entites;
using MVC_Blog_Sitesi.Models;
using MVC_Blog_Sitesi.Repository;
using System;
using System.IO;
using System.Threading.Tasks;

namespace MVC_Blog_Sitesi.Controllers
{
    public class ArticleController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IArticleRepository<Article> articleRepository;

        public ArticleController(UserManager<AppUser> userManager, IArticleRepository<Article> articleRepository)
        {
            this.userManager = userManager;
            this.articleRepository = articleRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ArticleVM articleVM)
        {
            AppUser appUser = await userManager.GetUserAsync(HttpContext.User); //Bu sayede login olan kullanıcının verilerine ulaşabileceğim.

            Article article=new Article();
            article.Title = articleVM.Title;
            article.Content = articleVM.Content;
            article.AppUserId=appUser.Id;

            if (articleVM.Image != null)
            {
                var imageExtension=Path.GetExtension(articleVM.Image.FileName);
                var newImageName = Guid.NewGuid() + imageExtension;
                var location= Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/", newImageName);
                var stream=new FileStream(location, FileMode.Create);
                await articleVM.Image.CopyToAsync(stream);

                article.Image = newImageName;
            }
            else
            {
                
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{1}");
                var stream = new FileStream(path, FileMode.Create);
                await articleVM.Image.CopyToAsync(stream);

              
            }



            if (ModelState.IsValid)
            {
                articleRepository.Add(article);
            }
            else
            {
                ViewBag.Message = "kayıt gerçekleşmedi";
            }
            return View();
        }

    }
}
