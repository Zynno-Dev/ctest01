using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using static WebApplication1.Models.DatosClassModel;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Random()
        {
            return "Este es el segundo test";
        }

/*        public string Chizzi(DatosClassModel.Edad,Nombre,Apellido,DNI)
        {
            return HtmlEncoder.Default.Encode($"Nombre: {Nombre}, Apellido: {Apellido}, Edad: {Edad}, Dni: {DNI}");
        } */
    }
}