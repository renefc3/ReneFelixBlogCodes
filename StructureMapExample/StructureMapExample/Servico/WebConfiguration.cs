using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Infraestrutura;

namespace Servico
{
    public class WebConfiguration : IConfigurations
    {
        public ConfigurationsInfo PegarConfiguracao()
        {
            if (HttpContext.Current.Session["NomeUsuario"] == null)
            {
                HttpContext.Current.Session["NomeUsuario"] = "Nome do usuario na Web";
            }
            return new ConfigurationsInfo()
                   {
                       Ambiente = TipoAmbiente.Web,
                       NomeUsuario = HttpContext.Current.Session["NomeUsuario"].ToString()
                   };
        }
    }
}
