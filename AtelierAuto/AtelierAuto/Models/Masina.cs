using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AtelierAuto.Models.Generic;

namespace AtelierAuto.Models
{
    public class Masina
    {    
        public PlainText Model { get; private set; }
        public int anFabricatie { get; private set; }
        public CIV civ { get; private set; }
        public SerieSasiu serieSasiu { get; private set; }

        public Masina(PlainText model, int anFabricatie, CIV civ, SerieSasiu serieSasiu)
        {
            Model = model;
            this.anFabricatie = anFabricatie;
            this.civ = civ;
            this.serieSasiu = serieSasiu;
        }
    }
}