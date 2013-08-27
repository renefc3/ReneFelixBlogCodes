using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploVariaveis
{
    public partial class Exemplo : System.Web.UI.Page
    {
        private static string valorVariavelEstatica;

        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarValores();
        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            if (Cache["varCache"] != null)
                Cache.Remove("varCache");

            Cache.Insert("varCache", TXT_ValorCache.Text, null, DateTime.Now.AddMinutes(2), System.Web.Caching.Cache.NoSlidingExpiration);

            Session["varSessao"] = TXT_ValorSessao.Text;
            valorVariavelEstatica = TXT_ValorEstatico.Text;

            CarregarValores();
        }

        private void CarregarValores()
        {
            if (Session["varSessao"] != null)
                LBL_SessaoAtual.Text = Session["varSessao"].ToString();
            else
                LBL_SessaoAtual.Text = string.Empty;

            if (Cache["varCache"] != null)
                LBL_CacheAtual.Text = Cache["varCache"].ToString();
            else
                LBL_CacheAtual.Text = string.Empty;


            if (valorVariavelEstatica != null)
                LBL_EstaticoAtual.Text = valorVariavelEstatica;
            else
                LBL_EstaticoAtual.Text = string.Empty;

        }
    }
}