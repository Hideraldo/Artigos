using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Artigos.Models;

namespace Artigos.Controllers
{
    public class HomeController : Controller
    {
        private bd_artigosEntities db = new bd_artigosEntities();

        public ActionResult Index()
        {
            //return View();
            var tbl_artigos = db.tbl_artigos.Include(t => t.tbl_desenvolvedor);
            return View(tbl_artigos.ToList().OrderByDescending(c => c.cadastro));
        }
    }
}