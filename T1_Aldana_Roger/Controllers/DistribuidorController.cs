using Microsoft.AspNetCore.Mvc;
using T1_Aldana_Roger.Datos;
using T1_Aldana_Roger.Models;

namespace T1_Aldana_Roger.Controllers
{
    public class DistribuidorController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DistribuidorController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Distribuidor> lista = _db.Distribuidor;
            return View(lista);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Distribuidor distribuidor)
        {
            if (ModelState.IsValid)
            {
                _db.Distribuidor.Add(distribuidor);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(distribuidor);
        }

        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var distribuidor = _db.Distribuidor.Find(id);

            if (distribuidor == null)
            {
                return NotFound();
            }

            return View(distribuidor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Distribuidor distribuidor)
        {
            if (ModelState.IsValid)
            {
                _db.Distribuidor.Update(distribuidor);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(distribuidor);
        }

        public IActionResult Eliminar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var distribuidor = _db.Distribuidor.Find(id);

            if (distribuidor == null)
            {
                return NotFound();
            }

            return View(distribuidor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Eliminar(Distribuidor distribuidor)
        {
            if (distribuidor == null)
            {
                return NotFound();
            }

            _db.Distribuidor.Remove(distribuidor);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}