using Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Armes;
using Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Armures;
using Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Personnages;
using Héroique_Fantasy_en_Desgin_pattern.Models.Interfaces;

namespace Héroique_Fantasy_en_Desgin_pattern.Models.Specialized.Personnages
{
    public class Orque : Personnage
    {
        public Orque(string nom, IArme armeEquipee = null!, Armure armureEquipee = null!) : base(nom, armeEquipee, armureEquipee)
        {
        }

        public override bool EquiperArme(IArme arme)
        {
            if (arme is ArmeDistance)
            {
                Console.WriteLine("Les orques ne peuvent pas utiliser d'arme à distance!");
                return false;
            }
            ArmeEquipee = arme;
            return true;
        }

        public override bool EquiperArmure(IArmure armure)
        {
            if (armure is ArmureLegere)
            {
                Console.WriteLine("Les orques ne peuvent pas porter d'armure légère!");
                return false;
            }

            ArmureEquipee = armure;
            return true;
        }
    }
}
