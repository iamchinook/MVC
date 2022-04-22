using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Web;

namespace MVC.Controllers
{
    public class UsuarioController : Controller
    {
       public ActionResult Buscar(string nombre)
        {
            string input = "Resultado de la busqueda: " + nombre;
            return Content(input);
        }
    }
}