using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDED_Scripting_202320_Parcial2
{
    // Clase base para representar a todos los personajes
    // Clase abstracta para representar a todos los personajes
    public abstract class Character
    {
        public string Name { get; set; }
        public Weapon weapon { get; set; }
        public Armor armor { get; set; }
        public List<Accessory> accessories { get; set; }
        public Move Moves { get; set; }

        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Skill { get; set; }
        public int Speed { get; set; }

        public Character(string name, Weapon weapon, Armor armor, List<Accessory> accessories, Move moves, int attack, int defense, int skill, int speed)
        {
            Name = name;
            this.weapon = weapon;
            this.armor = armor;
            this.accessories = accessories;
            Moves = moves;
            Attack = attack + weapon.AttackModifier;
            Defense = defense + armor.DefenseModifier;
            Skill = skill;
            Speed = speed;

            if (accessories != null && accessories.Count <= 3)
            {
                foreach (var accessory in accessories)
                {
                    Attack += accessory.AttackModifier;
                    Defense += accessory.DefenseModifier;
                    Skill += accessory.SkillModifier;
                    Speed += accessory.SpeedModifier;
                }
            }
            else
            {
                throw new ArgumentException("A character can't have more than 3 accessories.");
            }

        }
    }

    // Clase para representar a los personajes jugables
    public class PlayableCharacter : Character
    {
        public PlayableCharacter(string name, Weapon weapon, Armor armor, List<Accessory> accessories, Move moves, int attack, int defense, int skill, int speed) 
            : base(name, weapon, armor, accessories, moves, attack, defense, skill, speed)
        {
        }
    }

    // Clase para representar a los enemigos
    public class EnemyCharacter : Character
    {
        public EnemyCharacter(string name, Weapon weapon, Armor armor, List<Accessory> accessories, Move moves, int attack, int defense, int skill, int speed) 
            : base(name, weapon, armor, accessories, moves, attack, defense, skill, speed)
        {
        }
    }

}
