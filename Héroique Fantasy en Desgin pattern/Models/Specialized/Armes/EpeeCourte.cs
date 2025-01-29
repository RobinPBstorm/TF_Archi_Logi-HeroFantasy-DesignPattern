using Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Armes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héroique_Fantasy_en_Desgin_pattern.Models.Specialized.Armes
{
    public class EpeeCourte : ArmeContact
    {
        public override string Nom
        {
            get
            {
                return $"une {_Nom}";
            }
            set
            {
                _Nom = value;
            }
        }
        public EpeeCourte(string nom = "Épée courte", int degat = 6) : base(nom, degat)
        {
        }
    }
}
