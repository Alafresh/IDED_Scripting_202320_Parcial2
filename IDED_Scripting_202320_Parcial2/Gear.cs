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
        public Gear(int attackModifier, int defenseModifier, int skillModifier, int speedModifier)
        {
            if (attackModifier <= 10)
                AttackModifier = attackModifier;
            if (defenseModifier <= 10)
                DefenseModifier = defenseModifier;
            if (skillModifier <= 10)
                SkillModifier = skillModifier;
            if (speedModifier <= 10)
                SpeedModifier = speedModifier;
            else
                throw new ArgumentException("Gear modifiers must be less than 10.");
        }
    }

    public class Weapon : Gear
    {
        public Weapon(int attackModifier, int skillModifier) : base(attackModifier, 0, skillModifier, 0)
        {
            if ( attackModifier <= 10 && attackModifier > 5)
            {
                SkillModifier += skillModifier;
            }
        }
    }

    public class Armor : Gear
    {
        public Armor(int defenseModifier,  int speedModifier) : base(0, defenseModifier, 0, speedModifier)
        {
 
            if (defenseModifier <=10 && defenseModifier >5)
            {
                SpeedModifier -= speedModifier;
            }
               
        }
    }

    public class Accessory : Gear
    {
        public Accessory(int attackModifier, int defenseModifier, int skillModifier, int speedModifier) 
            : base(attackModifier, defenseModifier, skillModifier, speedModifier)
        {
        }
    }
}
