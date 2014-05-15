using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Infraestrutura;
using StructureMap;

namespace Servico
{
    public static class Mapeador
    {
        public static void Map()
        {
            
            if (HttpContext.Current == null)
            {
                ObjectFactory.Configure(x =>
                 x.For(typeof(IConfigurations)).Use(typeof(LocalConfiguration)));
            }
            else
            {
                ObjectFactory.Configure(x =>
                 x.For(typeof(IConfigurations)).Use(typeof(WebConfiguration)));
            }

        }

        public static T Get<T>()
        {
            return ObjectFactory.GetInstance<T>();
        }
    }
}
