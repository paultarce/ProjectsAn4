﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AtelierAuto.Models.Generic;

namespace AtelierAuto.Models
{
    public class Masina
    {    
        public string Model { get;  set; }
        public int anFabricatie { get;  set; }
        public CIV civ { get;  set; }
        public SerieSasiu serieSasiu { get;  set; }

        public Masina()
        {

        }
        public Masina(string model, int anFabricatie, CIV civ, SerieSasiu serieSasiu)
        {
            Model = model;
            this.anFabricatie = anFabricatie;
            this.civ = civ;
            this.serieSasiu = serieSasiu;
        }
    }
}