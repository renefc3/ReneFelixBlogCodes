using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestrutura;
using Servico;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Mapeador.Map();
            IConfigurations configurations = Mapeador.Get<IConfigurations>();
            var config = configurations.PegarConfiguracao();
            Console.WriteLine(config.Ambiente + " - Usuario:" + config.NomeUsuario);

            Console.ReadKey();
        }
    }
}
