using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CatalogoDeProdutosMVC.Models;

namespace CatalogoDeProdutosMVC.Controllers;

public class ProdutoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.produtos = new List<string>
        {
            "Maçã", "Banana" , "Morango", "Uva", "Limão"
        };

        ViewBag.precos = new List<double>
        {
            2.00 , 8.50, 5.99, 3.80, 1.50
        };

        return View();

    }
        
}
    