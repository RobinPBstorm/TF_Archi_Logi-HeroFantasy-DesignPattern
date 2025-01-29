using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Armures;

namespace Héroique_Fantasy_en_Desgin_pattern.Models.Specialized.Armures
{
    public class CotteDeMailles : ArmureLourde
    {
        public CotteDeMailles(string nom = "Cotte de mailles", int protection = 16) : base(nom, protection)
        {
        }

    }
}
