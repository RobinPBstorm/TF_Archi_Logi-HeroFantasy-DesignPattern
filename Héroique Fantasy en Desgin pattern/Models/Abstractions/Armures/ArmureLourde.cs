﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Armures
{
    public abstract class ArmureLourde : Armure
    {
        protected ArmureLourde(string nom, int protection) : base(nom, protection) { }

    }
}
