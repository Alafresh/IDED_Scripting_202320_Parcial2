using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDED_Scripting_202320_Parcial2
{
    // Enumeración para los tipos de habilidades
    public enum MoveType
    {
        Magic,
        Technique,
        Trick
    }
    // Clase para representar las habilidades Moves
    public class Move
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public MoveType Type { get; set; }
    }
}
