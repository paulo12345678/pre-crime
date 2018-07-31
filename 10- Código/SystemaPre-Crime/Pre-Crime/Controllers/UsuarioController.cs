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
        private GerenciarUsuario gu;

        public UsuarioController() => gu = new GerenciarUsuario();

        public IActionResult Index()
        {
            List<Usuario> model = gu.ExibirListaUsuarios();
            if (model.Count == 0)
                model = null;
            return View(model);
        }

        // GET: Usuario/Details/5
        public IActionResult Details(int? id)
        {
            Usuario u = gu.ObterById(id);
            if(id == null)
                return View(u);

            return View(u);
        }

        // GET: Usuario/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Usuario u)
        {
            try
            {
                if (ModelState.IsValid)
                    gu.Adicionar(u);

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
                Usuario u = gu.ObterById(id);
                if (u != null)
                    return View(u);
            }
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Usuario u)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gu.Editar(u);
                    return RedirectToAction("Index");
                }
                return View(u);
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
                Usuario u = gu.ObterById(id);
                if (u != null)
                    return View(u);
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