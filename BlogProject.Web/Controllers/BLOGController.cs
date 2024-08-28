using BlogProject.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlogProject.Web.Controllers
{
    //controller
    public class BLOGController : Controller
    {

        public IActionResult Project()
        {
            var image = new BLOG();
            image.HesapMakinesi = "hesap.png";
            image.AdamAsmaca = "adamasmaca.png";
            return View(image);
        }

        public IActionResult Hesapmakinesi()
        {
            var image = new BLOG();
            image.HesapMakinesi = "hesapmakinesi.jpg";
            return View(image);
        }

        public IActionResult Adamasmaca()
        {
            var image = new BLOG();
            image.KazananAdam = "dogru.png";
            image.KaybedenAdam = "yanlis.png";
            image.BaslangicAdam = "baslangic.png";
            return View(image);
        }

        public IActionResult AdamKod()
        {
            var cods = new BLOG();
            cods.KodSatiri= System.IO.File.ReadAllText("wwwroot/files/adamasmaca.txt");
            return View(cods);
        }

        public IActionResult HesapKod()
        {
            var cods = new BLOG();
            cods.KodSatiri = System.IO.File.ReadAllText("wwwroot/files/hesapMakinesi.txt");
            return View(cods);
        }

        public IActionResult Socialmedia()
        {
            var image = new BLOG();
            image.InstaIMAGE = "instagram.jpeg";
            image.TwitterIMAGE = "twitter.png";
            image.LinkIMAGE = "linkedln.png";
            return View(image);
        }



    }
}
