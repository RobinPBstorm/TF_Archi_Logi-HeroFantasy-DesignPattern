﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Armures;

namespace Héroique_Fantasy_en_Desgin_pattern.Models.Specialized.Armures
{
    public class ArmureDeCuir : ArmureLegere
    {
        public ArmureDeCuir(string nom = "Armure de cuir", int protection = 11) : base(nom, protection)
        {
        }
    }
}
