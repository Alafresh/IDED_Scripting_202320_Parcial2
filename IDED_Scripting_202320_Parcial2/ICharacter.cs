using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDED_Scripting_202320_Parcial2
{
    // Interfaz para las clases de personajes
    public interface ICharacter
    {
        string ClassName { get; }
        bool CanUseMagic { get; }
        bool CanUseTechniques { get; }
        bool CanUseTricks { get; }

    }

    // Implementación de las clases de personajes
    public class WarriorClass : PlayableCharacter, ICharacter
    {
        public WarriorClass(string name, Weapon weapon, Armor armor, List<Accessory> accessories, Move moves, int attack, int defense, int skill, int speed) 
            : base(name, weapon, armor, accessories, moves, attack, defense, skill, speed)
        {
            // Verifica si el tipo de habilidad es "Technique"
            if (moves.Type != MoveType.Technique)
            {
                throw new ArgumentException("Warriors can only use Technique moves.");
            }
            else
            {
                this.Moves = moves;
            }
            if (attack <= 0 || defense <= 0 || skill <= 0 || speed <= 0)
            {
                throw new ArgumentException("Warrior attributes must be greater than 0.");
            }
        }

        public string ClassName => "Warrior";
        public bool CanUseMagic => false;
        public bool CanUseTechniques => true;
        public bool CanUseTricks => false;


    }

    public class MageClass : PlayableCharacter, ICharacter
    {
        public MageClass(string name, Weapon weapon, Armor armor, List<Accessory> accessories, Move moves, int attack, int defense, int skill, int speed) 
            : base(name, weapon, armor, accessories, moves, attack, defense, skill, speed)
        {
            if (moves.Type != MoveType.Magic)
            {
                throw new ArgumentException("Mages can only use Magic moves.");
            }
            else
            {
                this.Moves = moves;
            }
            if (attack <= 0 || defense <= 0 || skill <= 0 || speed <= 0)
            {
                throw new ArgumentException("Mages attributes must be greater than 0.");
            }
        }

        public string ClassName => "Mage";
        public bool CanUseMagic => true;
        public bool CanUseTechniques => false;
        public bool CanUseTricks => false;

    }

    public class ThiefClass : PlayableCharacter, ICharacter
    {
        public ThiefClass(string name, Weapon weapon, Armor armor, List<Accessory> accessories, Move moves, int attack, int defense, int skill, int speed) 
            : base(name, weapon, armor, accessories, moves, attack, defense, skill, speed)
        {
            if (moves.Type != MoveType.Trick)
            {
                throw new ArgumentException("Thief can only use Tricks moves.");
            }
            else
            {
                this.Moves = moves;
            }
            if (attack <= 0 || defense <= 0 || skill <= 0 || speed <= 0)
            {
                throw new ArgumentException("Thief attributes must be greater than 0.");
            }
        }

        public string ClassName => "Thief";
        public bool CanUseMagic => false;
        public bool CanUseTechniques => false;
        public bool CanUseTricks => true;
        
    }

    public class MonsterClass : EnemyCharacter, ICharacter
    {
        public MonsterClass(string name, Weapon weapon, int attack, int speed, Move move)
        : base(name, weapon, null, null, null, attack, 0, 0, speed)
        {
            // Forzar el valor de Skill a 0
            Skill = 0;
            Attack += (weapon != null ? weapon.AttackModifier : 0);
        }
        
        public string ClassName => "Monster";
        public bool CanUseMagic => true;
        public bool CanUseTechniques => true;
        public bool CanUseTricks => true;

    }
}
