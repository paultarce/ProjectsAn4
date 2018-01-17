using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtelierAuto.Models
{
    public class MasinaMvc
    {
        public string Model { get; set; }
        public int anFabricatie { get; set; }
        public string civ { get; set; }
        public string serieSasiu { get; set; }

        public MasinaMvc()
        {

        }
        public MasinaMvc(string model, int anFabricatie, string civ, string serieSasiu)
        {
            Model = model;
            this.anFabricatie = anFabricatie;
            this.civ = civ;
            this.serieSasiu = serieSasiu;
        }
    }
}
