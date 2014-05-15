using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Infraestrutura;
using Servico;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            //IConfigurations configurations = new WebConfiguration();
            IConfigurations configurations = Mapeador.Get<IConfigurations>();
            var config = configurations.PegarConfiguracao();
            return View(config);
        }
	}
}