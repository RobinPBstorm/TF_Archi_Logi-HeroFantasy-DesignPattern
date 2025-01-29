using Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Armes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héroique_Fantasy_en_Desgin_pattern.Models.Specialized.Armes
{
    public class ArcLong : ArmeDistance
    {
        public ArcLong(string nom = "Arc long", int degat = 8, int portee = 45) : base(nom, degat, portee)
        {
        }
    }
}
