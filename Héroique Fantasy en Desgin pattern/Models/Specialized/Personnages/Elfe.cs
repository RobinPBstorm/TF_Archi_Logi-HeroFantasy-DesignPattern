using Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Armures;
using Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Personnages;
using Héroique_Fantasy_en_Desgin_pattern.Models.Interfaces;

namespace Héroique_Fantasy_en_Desgin_pattern.Models.Specialized.Personnages
{
    public class Elfe : Personnage
    {
        public Elfe(string nom, IArme armeEquipee = null!, Armure armureEquipee = null!) : base(nom, armeEquipee, armureEquipee)
        {
        }

        public override bool EquiperArme(IArme arme)
        {
            ArmeEquipee = arme;
            return true;
        }

        public override bool EquiperArmure(IArmure armure)
        {
            if (armure is not ArmureLegere)
            {
                Console.WriteLine("Les elfes ne peuvent porter que des armure légère!");
                return false;
            }
            ArmureEquipee = armure;
            return true;
        }
    }
}
