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
    public class ObjetosFurtadosController : Controller
    {
        private GerenciadoraObjetosRoubados gor;

        public ObjetosFurtadosController()
        {
            gor = new GerenciadoraObjetosRoubados();
        }

        public IActionResult Index()
        {
            List<ObjetosFurtados> model = gor.ObterTodos();
            if(model.Count == 0)
                model = null;
            return View(model);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cadastrar(ObjetosFurtados obj_objetos_furtados)
        {
            try
            {
                if(ModelState.IsValid)
                    gor.Adicionar(obj_objetos_furtados);
                return RedirectToAction("Index");
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
                ObjetosFurtados objetosFurtados = gor.ObterById(id);
                if (objetosFurtados != null)
                    return View(objetosFurtados);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Edit(ObjetosFurtados obj_objetos_furtados)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    gor.Editar(obj_objetos_furtados);
                    return RedirectToAction("Index");
                }
                return View(obj_objetos_furtados);

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
                ObjetosFurtados objetos = gor.ObterById(id);
                if (objetos != null)
                    return View(objetos);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(IFormCollection form)
        {
            try
            {
                if (ModelState.IsValid)

                    gor.Remover(int.Parse(form["id"]));
                    
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public IActionResult Details(int? id)
        {
            ObjetosFurtados Obj_usuario = gor.ObterById(id);
            if (id == null)
                return View(Obj_usuario);

            return View(Obj_usuario);
        }
    }
}