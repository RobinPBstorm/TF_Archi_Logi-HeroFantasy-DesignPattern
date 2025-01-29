using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Armes
{
    public abstract class ArmeDistance : Arme
    {
        public int Portee { get; set; }
        protected ArmeDistance(string nom, int degat, int portee) : base(nom, degat)
        {
            Portee = portee;
        }
    }
}
