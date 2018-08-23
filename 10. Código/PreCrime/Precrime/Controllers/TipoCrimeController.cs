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
            TipoCrime Tipo = gtp.ObterById(id);
            if (id == null)
                return View(Tipo);
            return View(Tipo);
            
        }

        // GET: TipoCrime/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoCrime/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TipoCrime tipoCrime)
        {
            try
            {
                if (ModelState.IsValid)
                    gtp.Adicionar(tipoCrime);
                    return RedirectToAction(nameof(Index));
                
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
                TipoCrime tipo = gtp.ObterById(id);
                if (tipo != null)
                    return View(tipo);
            }
            return RedirectToAction("Index");
        }

        // POST: TipoCrime/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TipoCrime tipo )
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gtp.Editar(tipo);
                    return RedirectToAction("Index");
                }
                return View(tipo);
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
                TipoCrime tipo = gtp.ObterById(id);
                if (tipo != null)
                    return View(tipo);
            }
            return RedirectToAction("Index");
        }

        // POST: TipoCrime/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(IFormCollection form)
        {
            try
            {
                if (ModelState.IsValid)
                    gtp.Remove(int.Parse(form["id"]));
                return RedirectToAction(("Index"));
            }
            catch
            {
                return View();
            }
        }
    }
}