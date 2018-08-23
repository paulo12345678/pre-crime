using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Business;
using Model.Models;

namespace Precrime.Controllers
{
    public class TipoCrimeController : Controller
    {

        private GerenciarTipoCrime gtp;

        public TipoCrimeController() => gtp = new GerenciarTipoCrime();

        public IActionResult Index()
        {
            List<TipoCrime> model = gtp.ObterTodos();
            if (model.Count == 0)
                model = null;
            return View(model);
        }

        // GET: TipoCrime/Details/5
        public IActionResult Details(int?id)
        {
            TipoCrime obj_tipo = gtp.ObterById(id);
            if (id == null)
                return View(obj_tipo);
            return View(obj_tipo);
            
        }

        // GET: TipoCrime/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoCrime/Create
        [HttpPost]
<<<<<<< HEAD
        [ValidateAntiForgeryToken]
        public IActionResult Create(TipoCrime tipoCrime)
=======
        //[ValidateAntiForgeryToken]
        public IActionResult Create(TipoCrime Obj_tipo)
>>>>>>> 8c8035fab5a3b6bd5f151a153211575f3a043d95
        {
            try
            {
                if (ModelState.IsValid)
<<<<<<< HEAD
                    gtp.Adicionar(tipoCrime);
                    return RedirectToAction(nameof(Index));
=======
                    gtp.Adicionar(Obj_tipo);
                    return RedirectToAction("Index");
>>>>>>> 8c8035fab5a3b6bd5f151a153211575f3a043d95
                
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoCrime/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                TipoCrime Obj_tipo = gtp.ObterById(id);
                if (Obj_tipo != null)
                    return View(Obj_tipo);
            }
            return RedirectToAction("Index");
        }

        // POST: TipoCrime/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TipoCrime Obj_tipo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gtp.Editar(Obj_tipo);
                    return RedirectToAction("Index");
                }
                return View(Obj_tipo);
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoCrime/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                TipoCrime Obj_tipo= gtp.ObterById(id);
                if (Obj_tipo != null)
                    return View(Obj_tipo);
            }
            return RedirectToAction("Index");
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(IFormCollection form)
        {
            try
            {
                if (ModelState.IsValid)
                    gtp.Remove(int.Parse(form["id"]));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}