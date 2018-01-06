using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AtelierAuto.Models.Generic;

namespace AtelierAuto.Commands
{
    public class CommandPlasareComanda: Command
    {
        public IDComanada iDComanada { get; set; }
        
    }
}