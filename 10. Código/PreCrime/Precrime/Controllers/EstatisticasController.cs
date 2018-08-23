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
    public class EstatisticasController : Controller
    {
        private GerenciadoraEstatisticas ge;

        public EstatisticasController() => ge = new GerenciadoraEstatisticas();

        public IActionResult Index()
        {
            List<Estatisticas> model = ge.ExibirTodos();
            if (model.Count == 0)
                model = null;
            return View(model);
        }

        public IActionResult Details(int? id)
        {
            Estatisticas objeto_estatistica = ge.ObterById(id);
            if(id == null)
                return View(objeto_estatistica);
            return View(objeto_estatistica);
        }

        
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estatisticas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Estatisticas obj_estatisticas)
        {
            try
            {
                if (ModelState.IsValid)
                    ge.Adicionar(obj_estatisticas);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public IActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                Estatisticas objeto_Estatisticas = ge.ObterById(id);
                if (objeto_Estatisticas != null)
                    return View(objeto_Estatisticas);
            }
            return RedirectToAction("Index");
        }

        // POST: Estatisticas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Estatisticas obj_Estatisticas)
        {
            try
            {
               if(ModelState.IsValid)
                {
                    ge.Editar(obj_Estatisticas);
                    return RedirectToAction("Index");
                }

                return View (obj_Estatisticas);
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Delete(int? id)
        {
            if(id.HasValue)
            {
                Estatisticas objetoEstatistica = ge.ObterById(id);
                if (objetoEstatistica != null)
                    return View(objetoEstatistica);
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(IFormCollection form)
        {
            try
            {
                if (ModelState.IsValid)
                    ge.Remover(int.Parse(form["id"]));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}