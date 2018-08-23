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
    public class ConfiguracoesController : Controller
    {
        private GerenciadoraConfiguracoes gc;

        public ConfiguracoesController() => gc = new GerenciadoraConfiguracoes();

        public IActionResult Index()
        {
            List<Configuracoes> model = gc.ObterTodos();
            if (model.Count == 0)
                model = null;
            return View(model);
        }

        // GET: Configuracoes/Details/5
        public IActionResult Details(int?id)
        {
            Configuracoes config = gc.ObterById(id);
            if (id == null)
                return View(config);
            return View(config);
        }

        // GET: Configuracoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Configuracoes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Configuracoes obj_config)
        {
            try
            {
                if (ModelState.IsValid)
                    gc.Adicionar(obj_config);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Configuracoes/Edit/5
        public IActionResult Edit(int?id)
        {
            if (id.HasValue)
            {
                Configuracoes obj_config = gc.ObterById(id);
                if (obj_config != null)
                    return View(obj_config);
            }
            return RedirectToAction("Index");
        }

        // POST: Configuracoes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Configuracoes obj_config)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gc.Editar(obj_config);
                    return RedirectToAction("Index");
                }
                return View(obj_config);
            }
            catch
            {
                return View();
            }
        }

        // GET: Configuracoes/Delete/5
        public IActionResult Delete(int?id)
        {
            if (id.HasValue)
            {
                Configuracoes obj_config = gc.ObterById(id);
                if (obj_config != null)
                    return View(obj_config);
            }
            return RedirectToAction("Index");
        }

        // POST: Configuracoes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(IFormCollection form)
        {
            try
            {
                if (ModelState.IsValid)
                    gc.Remover(int.Parse(form["id"]));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}