//Créer des Personnages de différentes race (Humain, Elfe, Orque)

//Tous pourront avoir une arme et une armure.
//	=> prévoir une méthode pour s'équiper de ces pièces d'équipements

//Les elfes ne peuvent s'équiper que d'armure légère.
//Alors que les orques ne peuvent pas porter d'armure légère, ne peuvent pas manier les arme à distance.

//Il faudra prévoir une méthode use pour les personnages qui donner les caractèriques des équipements qu'il porte.

using Héroique_Fantasy_en_Desgin_pattern.Models;
using Héroique_Fantasy_en_Desgin_pattern.Models.Abstractions.Personnages;
using Héroique_Fantasy_en_Desgin_pattern.Models.Specialized.Armes;
using Héroique_Fantasy_en_Desgin_pattern.Models.Specialized.Armures;
using Héroique_Fantasy_en_Desgin_pattern.Models.Specialized.Personnages;

List<Personnage> monEquipe = new List<Personnage>();
BoutiqueEquipement aLEnclumeUsee = new BoutiqueEquipement();


Humain filibert = new Humain("filibert");
while (!filibert.Equiper(aLEnclumeUsee.FounirArmure())) { }
monEquipe.Add(filibert);

Orque maurice = new Orque("maurice");
while (!maurice.Equiper(aLEnclumeUsee.FounirArmure())) { }
while (!maurice.Equiper(aLEnclumeUsee.FounirArme())) { }
monEquipe.Add(maurice);

Elfe duran = new Elfe("duran");
while (!duran.Equiper(aLEnclumeUsee.FounirArmure())) { }
while (!duran.Equiper(aLEnclumeUsee.FounirArme())) { }
monEquipe.Add(duran);

Console.WriteLine();
Console.WriteLine("- - -");
Console.WriteLine();

foreach (Personnage perso in monEquipe)
{
    Console.WriteLine(perso.CaracteristiqueEquipement());
}