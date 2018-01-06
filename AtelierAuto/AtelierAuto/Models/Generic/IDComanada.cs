using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtelierAuto.Models.Generic
{
    public class IDComanada
    {
        private Guid _id;
        public Guid Id { get { return _id; } }
        public IDComanada(Guid id)
        {
            _id = id;
        }

       
    }
}