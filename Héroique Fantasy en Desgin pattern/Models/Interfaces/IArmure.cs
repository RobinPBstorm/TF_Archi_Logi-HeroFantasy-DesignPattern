namespace Héroique_Fantasy_en_Desgin_pattern.Models.Interfaces
{
    public interface IArmure : IEquipement
    {
        public int Protection { get; init; }
        int Protege();
    }
}
