using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entity;
using ApplicationCore.Interfaces.Services;
using UI.Web.Data;

namespace UI.Web.Controllers
{
    public class EstudanteController : Controller
    {
        private readonly IEstudanteService _estudanteService;

        public EstudanteController(IEstudanteService estudanteService)
        {
            _estudanteService = estudanteService;
        }

        public IActionResult Index()
        {
            var estudantes = _estudanteService.ObterTodos();
            return View(estudantes);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudante = _estudanteService.ObterPorId(id.GetValueOrDefault());
            if (estudante == null)
            {
                return NotFound();
            }

            return View(estudante);
        }

        public IActionResult Create()
        {
            //ViewData["NivelEnsinoId"] = new SelectList(_context.Set<NivelEnsino>(), "Id", "Id");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Estudante estudante)
        {
            if (ModelState.IsValid)
            {
                _estudanteService.Adicionar(estudante);
                 return RedirectToAction(nameof(Index));
            }
            //ViewData["NivelEnsinoId"] = new SelectList(_context.Set<NivelEnsino>(), "Id", "Id", estudante.NivelEnsinoId);
            return View(estudante);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudante = _estudanteService.ObterPorId(id.GetValueOrDefault());
            if (estudante == null)
            {
                return NotFound();
            }
            //ViewData["NivelEnsinoId"] = new SelectList(_context.Set<NivelEnsino>(), "Id", "Id", estudante.NivelEnsinoId);
            return View(estudante);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Estudante estudante)
        {
            if (id != estudante.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _estudanteService.Atualizar(estudante);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstudanteExists(estudante.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            //ViewData["NivelEnsinoId"] = new SelectList(_context.Set<NivelEnsino>(), "Id", "Id", estudante.NivelEnsinoId);
            return View(estudante);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudante = _estudanteService.ObterPorId(id.GetValueOrDefault());
            if (estudante == null)
            {
                return NotFound();
            }

            return View(estudante);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var estudante = _estudanteService.ObterPorId(id);
            return RedirectToAction(nameof(Index));
        }

        private bool EstudanteExists(int id)
        {
            return _estudanteService.ObterTodos().Any(e => e.Id == id); 
        }
    }
}
