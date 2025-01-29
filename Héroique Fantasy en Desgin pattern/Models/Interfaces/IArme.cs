
using System.Security.Principal;

namespace Héroique_Fantasy_en_Desgin_pattern.Models.Interfaces
{
    public interface IArme : IEquipement
    {
        public int Degat { get; init; }
        int Infliqe();
    }
}
