﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AtelierAuto.Models.Generic;
namespace AtelierAuto.Models
{
    public class Mecanic
    {       
        public PlainText nume { get; private set; }
        public int idMecanic { get; private set; }

        public Mecanic(PlainText nume, int idMecanic)
        {
            this.nume = nume;
            this.idMecanic = idMecanic;
        }
    }
}