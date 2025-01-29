using Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Armes;
using Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Armures;
using Héroique_Fantasy_en_Desgin_pattern.Models.Interfaces;
using Héroique_Fantasy_en_Desgin_pattern.Models.Specialized.Armes;
using Héroique_Fantasy_en_Desgin_pattern.Models.Specialized.Armures;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héroique_Fantasy_en_Desgin_pattern.Models
{
    public class BoutiqueEquipement
    {
        public IArmure FounirArmure()
        {
            Random random = new Random();
            int hasard = random.Next(6);

            switch (hasard/2)
            {
                case 0:
                    return FournirArmureLegere(hasard % 2 == 0);
                case 1:
                    return FournirArmureIntermediaire(hasard % 2 == 0);
                case 2:
                    return FournirArmureLourde(hasard % 2 == 0);
                default:
                    return null!;
            }
        }
        public ArmureLegere FournirArmureLegere(bool luxueuse = false)
        {
            if (luxueuse)
            {
                return new ArmureDeCuir("Armre de cuir de luxe", 13);
            }
            else
            {
                return new ArmureDeCuir();
            }
        }
        public Armure FournirArmureIntermediaire(bool luxueuse = false)
        {
            if (luxueuse)
            {
                return new Cuirasse("Cuirasse de luxe", 16);
            }
            else
            {
                return new Cuirasse();
            }
        }
        public ArmureLourde FournirArmureLourde(bool luxueuse = false)
        {
            if (luxueuse)
            {
                return new CotteDeMailles("Cotte de maille de luxe", 18);
            }
            else
            {
                return new CotteDeMailles();
            }
        }

        public IArme FounirArme()
        {
            Random random = new Random();
            int hasard = random.Next(4);

            switch (hasard / 2)
            {
                case 0:
                    return FournirArmeContact(hasard%2 == 0);
                case 1:
                    return FournirArmeDistance(hasard % 2 == 0);
                default:
                    return null!;
            }
        }

        public ArmeContact FournirArmeContact(bool luxueuse = false)
        {
            Random random = new Random();
            int hasard = random.Next(3);

            switch(hasard)
            {
                case 0:
                    if (luxueuse)
                    {
                        return new Baton("Bâton de luxe", 8);
                    }
                    return new Baton();
                case 1:
                    if (luxueuse)
                    {
                        return new EpeeCourte("Épée courte de luxe", 8);
                    }
                    return new EpeeCourte();
                case 2:
                    if (luxueuse)
                    {
                        return new Gourdin("Gourdin de luxe", 6);
                    }
                    return new Gourdin();
                default:
                    return null!;


            }

        }
        public ArmeDistance FournirArmeDistance(bool luxueuse = false)
        {
            Random random = new Random();
            int hasard = random.Next(2);

            switch (hasard)
            {
                case 0:
                    if (luxueuse)
                    {
                        return new ArcCourt("Arc court de luxe", 8);
                    }
                    return new ArcCourt();
                case 1:
                    if (luxueuse)
                    {
                        return new ArcLong("Arc long de luxe", 10);
                    }
                    return new ArcLong();
                default:
                    return null!;
            }

        }
    }
}
