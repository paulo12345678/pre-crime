using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Models;
using Business.Business;

namespace Precrime.Controllers
{
    public class LocalizacaoController : Controller
    {
        private GerenciadoraLocalizacao gl;

        public LocalizacaoController() => gl = new GerenciadoraLocalizacao();
        public IActionResult Index()
        {
            List<Localizacao> model = gl.ObterTodos();
            if (model.Count == 0)
                model = null;
            return View(model);
        }

        // GET: Localizacao/Details/5
        public IActionResult Details(int?id)
        {
            Localizacao local = gl.ObterbyId(id);
            if (id == null)
                return View(local);
            return View(local);
        }

        // GET: Localizacao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Localizacao/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Localizacao obj_local)
        {
            try
            {
                if (ModelState.IsValid)
                    gl.Adicionar(obj_local);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Localizacao/Edit/5
        public IActionResult Edit(int?id)
        {
            if (id.HasValue)
            {
                Localizacao obj_local = gl.ObterbyId(id);
                if (obj_local != null)
                    return View(obj_local);
            }
            return RedirectToAction("Index");
        }

        // POST: Localizacao/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Localizacao obj_local)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gl.Editar(obj_local);
                    return RedirectToAction("Index");
                }
                return View(obj_local);
            }
            catch
            {
                return View();
            }
        }

        // GET: Localizacao/Delete/5
        public IActionResult Delete(int?id)
        {
            if (id.HasValue)
            {
                Localizacao obj_local = gl.ObterbyId(id);
                if (obj_local != null)
                    return View(obj_local);
            }
            return RedirectToAction("Index");
        }

        // POST: Localizacao/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(IFormCollection form)
        {
            try
            {
                if (ModelState.IsValid)
                    gl.Remover(int.Parse(form["id"]));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}