using Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Armures;
using Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Personnages;
using Héroique_Fantasy_en_Desgin_pattern.Models.Interfaces;
using Héroique_Fantasy_en_Desgin_pattern.Models.Specialized.Armes;

namespace Héroique_Fantasy_en_Desgin_pattern.Models.Specialized.Personnages
{
    public class Humain : Personnage
    {
        public Humain(string nom, IArme armeEquipee = null!, Armure armureEquipee = null!) : base(nom, armeEquipee, armureEquipee)
        {
        }

        public override bool EquiperArme(IArme arme)
        {
            ArmeEquipee = arme;
            return true;
        }

        public override bool EquiperArmure(IArmure armure)
        {
            ArmureEquipee = armure;
            return true;
        }
    }
}
