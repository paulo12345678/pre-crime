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
    public class OcorrenciaController : Controller
    {
        private GerenciadoraOcorrencia go;

        public OcorrenciaController()
        {
            go = new GerenciadoraOcorrencia();
        }


        public IActionResult Index()
        {
            List<Ocorrencia> model = go.ObterTodos();
            if (model.Count == 0)
                model = null;
            return View(model);
        }


        public IActionResult Details(int? id)
        {
            Ocorrencia obj_ocorrencia = go.ObterById(id);
            return View(obj_ocorrencia);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ocorrencia obj_ocorrencia)
        {
            try
            {
                if (ModelState.IsValid)
                    go.Adicionar(obj_ocorrencia);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public IActionResult Edit(int? id)
        {
            if(id.HasValue)
            {
                Ocorrencia obj_ocorrencia = go.ObterById(id);
                if (obj_ocorrencia != null)
                    return View(obj_ocorrencia);
            }
            return RedirectToAction("index");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Ocorrencia obj_ocorrencia)
        {
            try
            {
                if (ModelState.IsValid)
                    go.Editar(obj_ocorrencia);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public IActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                Ocorrencia obj_ocorrencia = go.ObterById(id);
                if (obj_ocorrencia != null)
                    return View(obj_ocorrencia);

            }
            return RedirectToAction("index");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(IFormCollection form)
        {
            try
            {
                if (ModelState.IsValid)
                    go.Remover(int.Parse(form["id"]));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}