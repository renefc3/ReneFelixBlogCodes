using Infraestrutura;

namespace Servico
{
    public class LocalConfiguration : IConfigurations
    {
        private static string nomeUsuario;
        public ConfigurationsInfo PegarConfiguracao()
        {
            if (nomeUsuario == null)
            {
                nomeUsuario = "Nome do usuario Local";
            }
            return new ConfigurationsInfo()
                   {
                       Ambiente = TipoAmbiente.Local,
                       NomeUsuario = nomeUsuario
                   };

        }
    }
}