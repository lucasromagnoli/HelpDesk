using System;
using HelpDesk.Context;
using HelpDesk.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Controllers
{
    public class OcorrenciaController : Controller
    {

        public IActionResult Index() {
            return View();
        }

        public IActionResult Cadastrar(){
            return View();
        }

        public IActionResult Exibir(string ocorrencia, int? input) {
            OcorrenciaContext ocorrenciaContext = HttpContext.RequestServices.GetService(typeof(HelpDesk.Context.OcorrenciaContext)) as OcorrenciaContext;
            OcorrenciaModel oc = ocorrenciaContext.getOcorrencia(ocorrencia);
            ViewData["MostrarErro"] = false;
            if (oc.Id == 0) // Nenhuma ocorrência encontrada.
            {
                ViewData["Encontrada"] = false;
                if (input == 1){
                    ViewData["MostrarErro"] = true;
                }

            }
            else {
                ViewData["Encontrada"] = true;
            }


            Console.WriteLine($"vaitomar no cu {input}");
            return View(oc);
        }

        [HttpPost]
        public IActionResult Cadastrar(OcorrenciaModel ocorrencia){
            OcorrenciaContext ocorrenciaContext = HttpContext.RequestServices.GetService(typeof(HelpDesk.Context.OcorrenciaContext)) as OcorrenciaContext;
            
            ocorrenciaContext.adicionaOcorrencia(ocorrencia);

            return View();
        }
    }
}