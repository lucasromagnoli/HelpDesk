using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelpDesk.Models;
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
            
            OcorrenciaContext ocorrenciaContext = HttpContext.RequestServices.GetService(typeof(HelpDesk.Models.OcorrenciaContext)) as OcorrenciaContext;
            Usuario usuario = new Usuario() {Id = 1, Login = "Lucas"};
            Setor setor = new Setor() {Id = 1, Nome = "TI"};
            OcorrenciaModel ocorrencia = new OcorrenciaModel(){

                DataDeRegistro = DateTime.UtcNow,
                DataDeVencimento = DateTime.UtcNow,
                Descrição = "DESCRIÇÃO!!!",
                Usuario = usuario,
                Setor = setor,

            };
            ocorrenciaContext.adicionaOcorrencia(ocorrencia);
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
