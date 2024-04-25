using G.EntidadesNegocio.EN;
using G.LogicaNegocio.BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace G.UI.AppWebMVC.Controllers
{
    public class PersonaGController : Controller
    {
        // GET: PersonaGController
        public async Task<ActionResult> Index()
        {
            var roles = await PersonaGBL.GetAll();
            return View(roles);
        }

        // GET: PersonaG/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var PersonaGDAL = await PersonaGBL.GetById(id);
            return View(PersonaGDAL);
        }

        // GET: PersonaG/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonaG/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PersonaEN pPersonaEN)
        {
            try
            {
                var result = await PersonaGBL.Create(pPersonaEN);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaG/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var PersonaGDAL = await PersonaGBL.GetById(id);
            return View(PersonaGDAL);
        }

        // POST: PersonaG/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PersonaEN pPersonaEN)
        {
            try
            {
                var result = await PersonaGBL.Update(pPersonaEN);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaG/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            
            return View();
        }

        // POST: PersonaG/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(PersonaEN personaEN)
        {
            try
            {
                var result = await PersonaGBL.Delete(personaEN);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
