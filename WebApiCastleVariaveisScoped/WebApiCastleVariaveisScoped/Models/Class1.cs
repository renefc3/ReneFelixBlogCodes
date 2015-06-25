using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiCastleVariaveisScoped.Models
{
    public interface IObjetosComEscopo
    {
        Guid Guid { get; set; }
    }

    public class ObjetosComEscopo : IObjetosComEscopo
    {
        public Guid Guid { get; set; }

        public ObjetosComEscopo()
        {
            this.Guid = Guid.NewGuid();
        }
    }


    public interface IObjetosSemEscopo
    {
        Guid Guid { get; set; }
    }

    public class ObjetosSemEscopo : IObjetosSemEscopo
    {
        public Guid Guid { get; set; }

        public ObjetosSemEscopo()
        {
            this.Guid = Guid.NewGuid();
        }
    }

}