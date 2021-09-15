using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudos.Controllers
{
    public class EstudosFrontEndController : Controller
    {
        public IActionResult Index()
        {
            return View("_Index");

        }
      
    }
}
