using HelpDesk.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index(){
            return View();
        }

        [HttpPost]
        public IActionResult Index(Usuario usuario, string senha) {
            return Index();
        } 

    }
}