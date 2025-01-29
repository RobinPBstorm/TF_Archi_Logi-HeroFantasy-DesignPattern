using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Armes
{
    public abstract class ArmeContact : Arme
    {
        protected ArmeContact(string nom, int degat) : base(nom, degat)
        {
        }
    }
}
