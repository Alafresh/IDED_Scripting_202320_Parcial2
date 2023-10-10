
namespace IDED_Scripting_202320_Parcial2
{
    public class Tests
    {
        [Test]
        public void CreateCharacters_WarriorCharacter_CreatesValidCharacter()
        {
            // Arrange
            Weapon weapon = new Weapon(8, 3); // Ensure valid attack and skill modifiers
            Armor armor = new Armor(5, 7); // Ensure valid defense and speed modifiers
            List<Accessory> accessories = new List<Accessory>
            {
                new Accessory(2, 3, 1, 0), // Sample accessory
            };
            Move move = new Move { Name = "Slash", Power = 15, Type = MoveType.Technique };

            // Act
            var warrior = new WarriorClass("Warrior1", weapon, armor, accessories, move, 10, 5, 2, 7);

            // Assert
            Assert.IsNotNull(warrior);
            Assert.AreEqual("Warrior1", warrior.Name);
            Assert.AreEqual(20, warrior.Attack); // Attack modified by weapon
            Assert.AreEqual(13, warrior.Defense); // Defense modified by armor
            Assert.AreEqual(3, warrior.Skill);  // Skill modified by accessory
            Assert.AreEqual(7, warrior.Speed);  // Speed not modified
        }

        [Test]
        public void CreateCharacters_MageCharacter_CreatesValidCharacter()
        {
            // Arrange
            Weapon weapon = new Weapon(6, 0); // Ensure valid attack modifier for a Mage
            Armor armor = new Armor(3, 5); // Ensure valid defense and speed modifiers
            List<Accessory> accessories = new List<Accessory>
            {
                new Accessory(1, 2, 4, 0),
            };
            Move move = new Move { Name = "Fireball", Power = 20, Type = MoveType.Magic };

            // Act
            var mage = new MageClass("Mage1", weapon, armor, accessories, move, 7, 3, 8, 6);

            // Assert
            Assert.IsNotNull(mage);
            Assert.AreEqual("Mage1", mage.Name);
            Assert.AreEqual(14, mage.Attack); // Attack modified by weapon

        }

        [Test]
        public void CreateCharacters_ThiefCharacter_CreatesValidCharacter()
        {
            // Arrange
            Weapon weapon = new Weapon(7, 1); // Ensure valid attack modifier for a Thief
            Armor armor = new Armor(4, 6); // Ensure valid defense and speed modifiers
            List<Accessory> accessories = new List<Accessory>
            {
                new Accessory(2, 1, 2, 3), // Sample accessory
            };
            Move move = new Move { Name = "Sneak Attack", Power = 18, Type = MoveType.Trick };

            // Act
            var thief = new ThiefClass("Thief1", weapon, armor, accessories, move, 8, 4, 5, 8);

            // Assert
            Assert.IsNotNull(thief);
            Assert.AreEqual("Thief1", thief.Name);
            Assert.AreEqual(17, thief.Attack); // Attack modified by weapon
            Assert.AreEqual(9, thief.Defense); // Defense modified by armor
            Assert.AreEqual(7, thief.Skill);  // Skill modified by accessory
            Assert.AreEqual(11, thief.Speed);  // Speed modified by accessory
        }

        [Test]
        public void CreateCharacters_MonsterCharacter_CreatesValidCharacter()
        {
            // Arrange
            Weapon weapon = new Weapon(9, 2); // Ensure valid attack modifier for a Monster
                                              // No armor and accessories for a Monster
            Move move = new Move { Name = "Roar", Power = 25, Type = MoveType.Technique };

            // Act
            var monster = new MonsterClass("Monster1", weapon, 9, 5, move); // Proporcionar el objeto Move

            // Assert
            Assert.IsNotNull(monster);
            Assert.AreEqual("Monster1", monster.Name);
            Assert.AreEqual(9, monster.Attack); // Attack modified by weapon
            Assert.AreEqual(0, monster.Defense); // No armor for a Monster
            Assert.AreEqual(0, monster.Skill);  // Skill is forced to 0 for a Monster
            Assert.AreEqual(5, monster.Speed);  // Speed not modified
        }
    }
}