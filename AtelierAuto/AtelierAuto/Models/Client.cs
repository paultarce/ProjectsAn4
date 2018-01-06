using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AtelierAuto.Models.Generic;

namespace AtelierAuto.Models
{
    public class Client
    {
       
        public PlainText nume { get; private set; }
        public int idClient { get; private set; }

        public Client(PlainText nume, int idClient)
        {
            this.nume = nume;
            this.idClient = idClient;
        }


    }
}