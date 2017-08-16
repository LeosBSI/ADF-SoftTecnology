using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TecnologySA.Models;

namespace TecnologySA.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Cadastro
        public ActionResult Index()
        {
            var cadastro = new Cadastro
                
                
                
            return View(Cadastro);
        }
    }
}