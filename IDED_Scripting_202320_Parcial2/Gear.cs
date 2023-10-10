using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDED_Scripting_202320_Parcial2
{
    // Clase para representar el equipamiento Gear
    public abstract class Gear
    {
        public int AttackModifier { get; set; }
        public int DefenseModifier { get; set; }
        public int SkillModifier { get; set; }
        public int SpeedModifier { get; set; }
    }

    public class Weapon : Gear
    {
        public int Damage { get; set; } // Propiedad específica de las armas
    }

    public class Armor : Gear
    {
        public int Durability { get; set; } // Propiedad específica de las armaduras
    }

    public class Accessory : Gear
    {
        public string SpecialEffect { get; set; } // Propiedad específica de los accesorios
    }
}
