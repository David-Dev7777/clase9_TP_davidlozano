using Microsoft.AspNetCore.Mvc;

namespace clase9_TP_davidlozano.Controllers
{
    public class bddController : Controller
    {
        public IActionResult ver_formulario()
        {
            return View("/Views/bbd/vista_bbd.cshtml");
        }
    }
}
