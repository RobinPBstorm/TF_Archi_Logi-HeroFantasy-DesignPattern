using Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Armes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héroique_Fantasy_en_Desgin_pattern.Models.Specialized.Armes
{
    public class Baton : ArmeContact
    {
        public Baton(string nom = "Bâton", int degat = 6) : base(nom, degat)
        {
        }
    }
}
