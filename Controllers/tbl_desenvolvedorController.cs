using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Artigos.Models;

namespace Artigos.Controllers
{
    public class tbl_desenvolvedorController : Controller
    {
        private bd_artigosEntities db = new bd_artigosEntities();

        // GET: tbl_desenvolvedor
        public ActionResult Index()
        {
            return View(db.tbl_desenvolvedor.ToList());
        }

        // GET: tbl_desenvolvedor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_desenvolvedor tbl_desenvolvedor = db.tbl_desenvolvedor.Find(id);
            if (tbl_desenvolvedor == null)
            {
                return HttpNotFound();
            }
            return View(tbl_desenvolvedor);
        }

        // GET: tbl_desenvolvedor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_desenvolvedor/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,nome,data_nasc,nivel")] tbl_desenvolvedor tbl_desenvolvedor)
        {
            if (ModelState.IsValid)
            {
                db.tbl_desenvolvedor.Add(tbl_desenvolvedor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_desenvolvedor);
        }

        // GET: tbl_desenvolvedor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_desenvolvedor tbl_desenvolvedor = db.tbl_desenvolvedor.Find(id);
            if (tbl_desenvolvedor == null)
            {
                return HttpNotFound();
            }
            return View(tbl_desenvolvedor);
        }

        // POST: tbl_desenvolvedor/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,nome,data_nasc,nivel")] tbl_desenvolvedor tbl_desenvolvedor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_desenvolvedor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_desenvolvedor);
        }

        // GET: tbl_desenvolvedor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_desenvolvedor tbl_desenvolvedor = db.tbl_desenvolvedor.Find(id);
            if (tbl_desenvolvedor == null)
            {
                return HttpNotFound();
            }
            return View(tbl_desenvolvedor);
        }

        // POST: tbl_desenvolvedor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_desenvolvedor tbl_desenvolvedor = db.tbl_desenvolvedor.Find(id);
            db.tbl_desenvolvedor.Remove(tbl_desenvolvedor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
