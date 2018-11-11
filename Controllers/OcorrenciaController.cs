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

        [HttpGet]
        public IActionResult Alterar(string ocorrencia, int? input){
            OcorrenciaContext ocorrenciaContext = HttpContext.RequestServices.GetService(typeof(HelpDesk.Context.OcorrenciaContext)) as OcorrenciaContext;
            UsuarioContext usuarioContext = HttpContext.RequestServices.GetService(typeof(HelpDesk.Context.UsuarioContext)) as UsuarioContext;

            OcorrenciaModel oc = ocorrenciaContext.getOcorrencia(ocorrencia, usuarioContext);
            ViewData["MostrarErro"] = false;
            if (oc.Id == 0) // Nenhuma ocorrência encontrada.
            {
                ViewData["Encontrada"] = false;
                if (input == 1){
                    ViewData["MostrarErro"] = true;
                }
            }
            else
            {
                ViewData["Encontrada"] = true;
            }
            
            return View(oc);
        }

        [HttpPost]
        public IActionResult Alterar(OcorrenciaModel ocorrenciaModel, string acompanhamento){
            OcorrenciaContext ocorrenciaContext = HttpContext.RequestServices.GetService(typeof(HelpDesk.Context.OcorrenciaContext)) as OcorrenciaContext;
            Acompanhamento tempAcompanhamento = new Acompanhamento(){Descricao = acompanhamento, Usuario = new Usuario() {Id = 1}};
            ocorrenciaContext.adicionaAcompanhamento(tempAcompanhamento,ocorrenciaModel);
            return RedirectToAction("Exibir", new { ocorrencia = ocorrenciaModel.Numero, alterado = "1"} );
        }

        [HttpGet]
        public IActionResult Cadastrar(){
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(OcorrenciaModel ocorrenciaModel, string categoriaNome){
            OcorrenciaContext ocorrenciaContext = HttpContext.RequestServices.GetService(typeof(HelpDesk.Context.OcorrenciaContext)) as OcorrenciaContext;
            ocorrenciaModel.Categoria = categoriaNome;
            ocorrenciaModel.Usuario = new Usuario() {Id = 1};
            ocorrenciaContext.adicionaOcorrencia(ocorrenciaModel);

            return RedirectToAction("Exibir", new { ocorrencia = ocorrenciaModel.Numero, cadastrado = "1"} );
        }
        public IActionResult Exibir(string ocorrencia, int? input, int? cadastrado, int? alterado) {
            OcorrenciaContext ocorrenciaContext = HttpContext.RequestServices.GetService(typeof(HelpDesk.Context.OcorrenciaContext)) as OcorrenciaContext;
            UsuarioContext usuarioContext = HttpContext.RequestServices.GetService(typeof(HelpDesk.Context.UsuarioContext)) as UsuarioContext;

            OcorrenciaModel oc = ocorrenciaContext.getOcorrencia(ocorrencia, usuarioContext);
            ViewData["MostrarErro"] = false;
            ViewData["Cadastrado"] = false;
            ViewData["Alterado"] = false;
            if (oc.Id == 0) // Nenhuma ocorrência encontrada.
            {
                ViewData["Encontrada"] = false;
                if (input == 1){
                    ViewData["MostrarErro"] = true;
                }
            }
            else {
                ViewData["Encontrada"] = true;
                if (cadastrado == 1)
                ViewData["Cadastrado"] = true;
                if (alterado == 1)
                ViewData["Alterado"] = true;
            }
            
            return View(oc);
        }
    }
}