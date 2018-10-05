using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Controllers
{
    public class OcorrênciaController : Controller
    {
        public IActionResult Index() {
            return View();
        }

        public IActionResult Cadastrar(){
            return Content("teste");
        }
        
    }
}