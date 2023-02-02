﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace SistemaWebEmpleado.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.Nombre = "Home de Empleados";
            return View("Index");
        }
    }
}
