using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDED_Scripting_202320_Parcial2
{
        // Clase para representar las habilidades Moves
    public abstract class Move
    {
            public string Name { get; set; }
            public int Power { get; set; }
            public string Type { get; set; }
    }
}
