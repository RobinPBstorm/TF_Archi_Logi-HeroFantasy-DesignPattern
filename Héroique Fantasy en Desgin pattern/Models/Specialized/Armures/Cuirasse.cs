using Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Armures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héroique_Fantasy_en_Desgin_pattern.Models.Specialized.Armures
{
    public class Cuirasse : ArmureIntermediaire
    {
        public Cuirasse(string nom = "Cuirasse", int protection = 14) : base(nom, protection)
        {
        }
    }
}
