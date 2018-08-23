using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Models;
using Business.Business;

namespace Pre_Crime.Controllers
{
    public class UsuarioController : Controller
    {
        private GerenciadoraUsuario gu;

        public UsuarioController() => gu = new GerenciadoraUsuario();

        public IActionResult Index()
        {
            List<Usuario> model = gu.ExibirListaUsuarios();
            if (model.Count == 0)
                model = null;
            return View(model);
        }

        public IActionResult Details(int? id)
        {
            Usuario Obj_usuario = gu.ObterById(id);
            if(id == null)
                return View(Obj_usuario);

            return View(Obj_usuario);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Usuario Obj_usuario)
        {
            try
            {
                if (ModelState.IsValid)
                    gu.Adicionar(Obj_usuario);

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
                Usuario Obj_usuario = gu.ObterById(id);
                if (Obj_usuario != null)
                    return View(Obj_usuario);
            }
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Usuario Obj_usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gu.Editar(Obj_usuario);
                    return RedirectToAction("Index");
                }
                return View(Obj_usuario);
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                Usuario Obj_usuario = gu.ObterById(id);
                if (Obj_usuario != null)
                    return View(Obj_usuario);
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
                    gu.Remover(int.Parse(form["id"]));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}