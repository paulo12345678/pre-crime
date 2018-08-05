using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public ActionResult Index()
        {
            List<TipoCrime> model = gtp.ObterTodos();
            if (model.Count == 0)
                model = null;
            return View(model);
        }

        // GET: TipoCrime/Details/5
        public ActionResult Details(int? id)
        {
            TipoCrime Tipo = gtp.ObterById(id);
            if (id == null)
                return View(Tipo);
            return View(Tipo);
            
        }

        // GET: TipoCrime/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoCrime/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoCrime tipo)
        {
            try
            {
                if (ModelState.IsValid)
                    gtp.Adicionar(tipo);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoCrime/Edit/5
        public ActionResult Edit(int? id)
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
        public ActionResult Edit(TipoCrime tipo )
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
        public ActionResult Delete(int? id)
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
        public ActionResult Delete(IFormCollection form)
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