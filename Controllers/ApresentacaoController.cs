using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvMovie.Controllers
{
    public class ApresentacaoController : Controller
    {
        //
        // GET: /Apresentacao/
        
        public IActionResult Index()
        {
           return View();
        }

        public IActionResult Profissao()
        {
            return View();
        }
    }   
}