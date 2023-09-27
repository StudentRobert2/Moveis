using Bloggie.Web.Models.Domain;
using Bloggie.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Moveis.Data;
using Moveis.Models.ViewModel.Admin;

namespace Moveis.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly MyFilmContext myFilmContext;

        public AdminTagsController(MyFilmContext myFilmContext)
        {
            this.myFilmContext = myFilmContext;
        }


        [HttpGet] // սա ստացող մեթոդ է
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost] // սա գրանցման մեթոդ է
        public IActionResult Add(AdminViewModel adminViewModel)
        {
            // Mapping AddTagRequest to Tag domain model
            var tag = new Tag
            {
                Name = adminViewModel.Name,
                Login = adminViewModel.Login,
                Password = adminViewModel.Password

            };

            myFilmContext.Tags.Add(tag);
            myFilmContext.SaveChanges();
            return View("Add");
        }
    }
}
