using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelpDesk.Models;
using HelpDesk.Context;
using System.IO;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace HelpDesk.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Indexx(int pagina){
            OcorrenciaModel ocorrenciaModel = new OcorrenciaModel();
            return Content($"pagina: {ocorrenciaModel.gerarNumero()}");
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page. nome: ";
            
            OcorrenciaContext ocorrenciaContext = HttpContext.RequestServices.GetService(typeof(HelpDesk.Context.OcorrenciaContext)) as OcorrenciaContext;
            ocorrenciaContext.getAcompanhamento("1");


            return Content($@"{ocorrenciaContext.getAcompanhamento("12345678901234").ToArray()[0].Descricao}");
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            UsuarioContext usuarioContext = HttpContext.RequestServices.GetService(typeof(UsuarioContext) ) as UsuarioContext;


            //return Content(usuarioContext.GetUsuario(1).Login);
            return Content(usuarioContext.AutenticaUsuario("admin", "123456") ? "Sim" : "Não");
            // return View();
        }

        public IActionResult Privacy()
        {

            return Content("");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
