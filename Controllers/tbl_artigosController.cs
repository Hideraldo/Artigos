using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Artigos.Models;

namespace Artigos.Controllers
{
    public class tbl_artigosController : Controller
    {
        private bd_artigosEntities db = new bd_artigosEntities();

        // GET: tbl_artigos
        public ActionResult Index()
        {
            var tbl_artigos = db.tbl_artigos.Include(t => t.tbl_desenvolvedor);
            return View(tbl_artigos.ToList());
        }

        // GET: tbl_artigos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_artigos tbl_artigos = db.tbl_artigos.Find(id);
            if (tbl_artigos == null)
            {
                return HttpNotFound();
            }
            return View(tbl_artigos);
        }

        // GET: tbl_artigos/Create
        public ActionResult Create()
        {
            ViewBag.desenvolvedor_id = new SelectList(db.tbl_desenvolvedor, "Id", "nome");
            return View();
        }

        // POST: tbl_artigos/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,titulo,texto,cadastro,ativo,desenvolvedor_id")] tbl_artigos tbl_artigos)
        {
            if (ModelState.IsValid)
            {
                db.tbl_artigos.Add(tbl_artigos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.desenvolvedor_id = new SelectList(db.tbl_desenvolvedor, "Id", "nome", tbl_artigos.desenvolvedor_id);
            return View(tbl_artigos);
        }

        // GET: tbl_artigos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_artigos tbl_artigos = db.tbl_artigos.Find(id);
            if (tbl_artigos == null)
            {
                return HttpNotFound();
            }
            ViewBag.desenvolvedor_id = new SelectList(db.tbl_desenvolvedor, "Id", "nome", tbl_artigos.desenvolvedor_id);
            return View(tbl_artigos);
        }

        // POST: tbl_artigos/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,titulo,texto,cadastro,ativo,desenvolvedor_id")] tbl_artigos tbl_artigos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_artigos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.desenvolvedor_id = new SelectList(db.tbl_desenvolvedor, "Id", "nome", tbl_artigos.desenvolvedor_id);
            return View(tbl_artigos);
        }

        // GET: tbl_artigos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_artigos tbl_artigos = db.tbl_artigos.Find(id);
            if (tbl_artigos == null)
            {
                return HttpNotFound();
            }
            return View(tbl_artigos);
        }

        // POST: tbl_artigos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_artigos tbl_artigos = db.tbl_artigos.Find(id);
            db.tbl_artigos.Remove(tbl_artigos);
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
