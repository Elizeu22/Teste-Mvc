using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valor_Prestacao.Controllers
{
    public class PrestacaoController : Controller
    {
        public IActionResult CalculoPrestacao()
        {
            return View();
        }
    }
}
