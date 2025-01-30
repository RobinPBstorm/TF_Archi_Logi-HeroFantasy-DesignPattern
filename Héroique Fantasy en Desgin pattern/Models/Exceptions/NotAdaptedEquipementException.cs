using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héroique_Fantasy_en_Desgin_pattern.Models.Exceptions
{
    public class NotAdaptedEquipementException : Exception
    {
        public NotAdaptedEquipementException(string? message = "L'equipement proposé n'est pas adapté!") : base(message)
        {
        }
    }
}
