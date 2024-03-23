using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TechStore.Models;

namespace TechStore.Controllers
{
    public class FormProductoController: Controller
    {
        private readonly ILogger<FormProductoController> _logger;

        public FormProductoController(ILogger<FormProductoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("Index");
        }
        // [HttpPost]
        // public IActionResult Create([Bind("Nombre,Producto,Precio")] FormProducto formProducto)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         ViewData["Message"] = "El Igv del producto es:"+(formProducto.Precio*0.18);
        //         
        //         return View("Index");
        //     }
        //     return View("Index");
        // }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}