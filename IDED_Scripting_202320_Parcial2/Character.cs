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
        public Gear EquippedGear { get; set; }
        public List<Move> Moves { get; set; }

        public int Attack { get; private set; }
        public int Defense { get; private set; }
        public int Skill { get; private set; }
        public int Speed { get; private set; }

        public Character()
        {
            Moves = new List<Move>();
        }

        public void CalculateStats()
        {
            // Calcular los atributos según el equipamiento y la clase de personaje
            Attack = EquippedGear.AttackModifier;
            Defense = EquippedGear.DefenseModifier;
            Skill = EquippedGear.SkillModifier;
            Speed = EquippedGear.SpeedModifier;

            // Aplicar modificaciones adicionales según las habilidades del personaje
            ApplyMoveEffects();
        }

        public void EquipGear(Gear gear)
        {
            // Implementar lógica para equipar piezas de equipamiento
            if (gear == null)
            {
                throw new ArgumentNullException(nameof(gear), "Gear cannot be null");
            }   

            EquippedGear = gear;
            CalculateStats();
        }

        public void AssignMove(Move move)
        {
            // Implementar lógica para asignar habilidades al personaje
            if (move == null)
            {
                throw new ArgumentNullException(nameof(move), "Move cannot be null");
            }
            Moves.Add(move);
        }

        private void ApplyMoveEffects()
        {
            // Implementar lógica para aplicar efectos de habilidades al personaje
            foreach (var move in Moves)
            {
                // Aquí puedes definir cómo cada habilidad afecta los atributos del personaje
                // Por ejemplo, si una habilidad aumenta el ataque en 10 puntos, puedes sumar 10 al atributo de ataque.
            }
        }
    }

    // Clase para representar a los personajes jugables
    public class PlayableCharacter : Character
    {
        // Puedes agregar propiedades específicas de personajes jugables si es necesario
    }

    // Clase para representar a los enemigos
    public class EnemyCharacter : Character
    {
        // Puedes agregar propiedades específicas de enemigos si es necesario
    }

}
