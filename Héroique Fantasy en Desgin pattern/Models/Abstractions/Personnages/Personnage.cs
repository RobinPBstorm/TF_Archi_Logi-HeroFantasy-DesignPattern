using Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Armures;
using Héroique_Fantasy_en_Desgin_pattern.Models.Exceptions;
using Héroique_Fantasy_en_Desgin_pattern.Models.Interfaces;

namespace Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Personnages
{
    public abstract class Personnage
    {
        protected string _Nom;
        public string Nom 
        {
            get
            {
                return _Nom;
            }
            set
            {
                if (value is null)
                {
                    throw new NoNameGivenException("Aucun nom a été donné à ce Personnage!");
                }
                _Nom = value;
            }
        }
        public IArme ArmeEquipee { get; protected set; } = null!;
        public IArmure ArmureEquipee { get; protected set; } = null!;

        protected Personnage(string nom, IArme armeEquipee = null!, IArmure armureEquipee = null!)
        {
            Nom = nom;
            Equiper(armeEquipee);
            Equiper(armureEquipee);
        }

        public abstract bool EquiperArmure(IArmure armure);

        public abstract bool EquiperArme(IArme arme);

        public bool Equiper(IEquipement equipement)
        {
            if (equipement is null)
            {
                return true;
            }
            switch (equipement)
            {
                case IArme:
                    return EquiperArme((IArme)equipement);
                case Armure:
                    return EquiperArmure((Armure)equipement);
                default:
                    Console.WriteLine("Ce n'est pas un piéce d'équipement connue");
                    return false;
            }
        }

        public string CaracteristiqueEquipement()
        {
            string content = $"{Nom} ";

            // Détail de l'armure
            if (ArmureEquipee is null)
            {
                content += "ne porte pas d'armure ";
            }
            else
            {
                content += $"porte {ArmureEquipee.Nom} le protégeant de {ArmureEquipee.Protege()} point de dégâts ";
            }

            // détails de l'arme
            if (ArmeEquipee is null)
            {
                content += "et n'est pas équipé d'une arme.";
            }
            else
            {
                content += $"et porte {ArmeEquipee.Nom} lui permettant de faire {ArmeEquipee.Infliqe()} point de dégâts.";
            }

            return content;
        }
    }
}
