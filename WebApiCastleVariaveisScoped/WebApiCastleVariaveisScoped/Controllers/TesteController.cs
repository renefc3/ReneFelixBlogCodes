using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using WebApiCastleVariaveisScoped.Models;

namespace WebApiCastleVariaveisScoped.Controllers
{
    public class TesteController : ApiController
    {
        private IObjetosSemEscopo semEscopo;
        private IObjetosComEscopo comEscopo;

        public TesteController(IObjetosComEscopo aa, IObjetosSemEscopo aa2)
        {
            comEscopo = aa;
            semEscopo = aa2;
            Thread.Sleep(new TimeSpan(0, 0, 25));
        }

        public RetornoGet Get()
        {
            Thread.Sleep(new TimeSpan(0, 0, 20));
            return new RetornoGet(comEscopo, semEscopo);
        }
    }

    public class RetornoGet
    {
        public Guid ComEscopo { get; set; }
        public Guid SemEscopo { get; set; }

        public RetornoGet()
        {
            
        }

        public RetornoGet(IObjetosComEscopo comEscopo, IObjetosSemEscopo semEscopo)
        {
            ComEscopo = comEscopo.Guid;
            SemEscopo = semEscopo.Guid;
        }
    }
}
