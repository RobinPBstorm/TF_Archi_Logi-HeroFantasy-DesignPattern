using Héroique_Fantasy_en_Desgin_pattern.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Armures
{
    public abstract class Armure : IArmure
    {
        public int Protection { get; init; }

        protected string _Nom;
        public virtual string Nom
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

        protected Armure(string nom, int protection)
        {
            Nom = nom;
            Protection = protection;
        }

        public int Protege()
        {
            return Protection;
        }
    }
}
