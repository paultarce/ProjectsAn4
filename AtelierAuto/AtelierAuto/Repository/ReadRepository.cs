using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AtelierAuto.Models;
using Newtonsoft.Json;
using System.IO;

namespace AtelierAuto.Repository
{
    public class ReadRepository
    {
        public ReadRepository()
        {

        }

        public IEnumerable<Comanda> ObtineComenzi()
        {
            List<Comanda> toateComenzile = new List<Comanda>();
            //read comenzi din DB
            return toateComenzile.AsEnumerable();

        }
        public Comanda CautMeci(Guid Id)
        {
            return ObtineComenzi().Where(m => (Guid)m.iDComanda == Id).FirstOrDefault();
        }
    }

   
}