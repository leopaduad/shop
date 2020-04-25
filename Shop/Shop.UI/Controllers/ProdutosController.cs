using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Entities;
using Shop.Infra.Data;
using Shop.UI.Models;
using System;
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
            var produto = new ProdutoViewModel() { produtos = _produto.GetAll() };
            return View(produto);
        }

        public IActionResult Salvar()
        {
            List<string> img = new List<string>();
            img.Add("https://images-americanas.b2w.io/produtos/01/00/oferta/134220/3/134220359_1GG.jpg");
            img.Add("https://images-americanas.b2w.io/produtos/01/00/oferta/134220/3/134220359_5GG.jpg");
            Random random = new Random();

            decimal value = random.Next(121, 314160);

            var p = new Produto("Celular ", Decimal.Round(value), img);
            _produto.Insert(p);

            return Json(_produto.GetAll());
        }

        public IActionResult Edit()
        {
            var p = new ProdutoViewModel() { produto = _produto.Get("Celular Iphone") };
            return View(p);
        }
    }
}