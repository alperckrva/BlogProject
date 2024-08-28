using BlogProject.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Web.Controllers
{
    //controller
    public class HomeController : Controller
    {

        //action
        public IActionResult Homepage()
        {
            var alp = new BLOG();
            alp.AlperenIMAGE = "alperne.png";
            return View(alp);
        }

        //localhost:5000/home/about
        public IActionResult About()
        {
            var alp = new BLOG();
            alp.AlperenIMAGE = "alperne.png";
            alp.AlperIMAGE = "alper.jpg";
            return View(alp);
        }

    }
}
