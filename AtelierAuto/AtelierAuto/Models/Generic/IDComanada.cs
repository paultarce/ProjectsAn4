using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtelierAuto.Models.Generic
{
    public class IDComanada
    {
        private string _id;
        public string Id { get { return _id; } }
        public IDComanada(string id)
        {
            _id = id;
        }

        public static explicit operator Guid(IDComanada v)
        {
            throw new NotImplementedException();
        }
    }
}