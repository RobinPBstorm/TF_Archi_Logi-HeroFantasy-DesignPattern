using Héroique_Fantasy_en_Desgin_pattern.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Armes
{
    public abstract class Arme : IArme
    {
        public int Degat { get; init; }

        protected string _Nom;
        public virtual string Nom 
        {
            get
            {
                return $"un {_Nom}";
            }
            set
            {
                _Nom = value;
            }
        }

        public Arme(string nom, int degat)
        {
            Nom = nom;
            Degat = degat;
        }

        public virtual int Infliqe()
        {
            return Degat;
        }
    }
}
