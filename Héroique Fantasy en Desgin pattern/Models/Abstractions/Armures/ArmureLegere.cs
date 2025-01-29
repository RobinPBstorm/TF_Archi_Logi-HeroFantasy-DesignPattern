using Héroique_Fantasy_en_Desgin_pattern.Models.Interfaces;

namespace Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Armures
{
    public abstract class ArmureLegere : Armure
    {
        protected ArmureLegere(string nom, int protection) : base(nom, protection) { }
    }
}
