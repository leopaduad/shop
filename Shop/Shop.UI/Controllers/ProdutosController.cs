using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Entities;
using Shop.Infra.Data;
using Shop.UI.Models;
using System.Collections.Generic;

namespace Shop.UI.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly BaseRepository _produto;

        public ProdutosController(BaseRepository produto)
        {
            _produto = produto;
        }
        public IActionResult Index()
        {
            var produto = new ProdutoViewModel() { produto = _produto.GetAll() };
            return View(produto);
        }

        public IActionResult Salvar()
        {
            List<string> img = new List<string>();
            img.Add("teste");
            img.Add("teste2");
            var p = new Produto("Celular", 23433, img);
            _produto.Insert(p);
            return Json(_produto.GetAll());
        }
    }
}