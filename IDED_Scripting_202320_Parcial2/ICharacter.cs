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
        public string ClassName => "Warrior";
        public bool CanUseMagic => false;
        public bool CanUseTechniques => true;
        public bool CanUseTricks => false;
    }

    public class MageClass : PlayableCharacter, ICharacter
    {
        public string ClassName => "Mage";
        public bool CanUseMagic => true;
        public bool CanUseTechniques => false;
        public bool CanUseTricks => false;

    }

    public class ThiefClass : PlayableCharacter, ICharacter
    {
        public string ClassName => "Thief";
        public bool CanUseMagic => false;
        public bool CanUseTechniques => false;
        public bool CanUseTricks => true;
    }

    public class MonsterClass : EnemyCharacter, ICharacter
    {
        public string ClassName => "Monster";
        public bool CanUseMagic => true;
        public bool CanUseTechniques => true;
        public bool CanUseTricks => true;
    }
}
