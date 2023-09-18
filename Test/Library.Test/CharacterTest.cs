using NUnit.Framework ;
using RPG ;

namespace RPG.Tests
{
    public class CharacterTest
    {
        [Test]
        public void ValidHealthPoint()
        {
            //Arrange
            Character testCharacter = new Character ("Test Character", 100, inventory, 3, 1 );
            
            int input = testingCharacter.HealthPoint ;
            int expected = 100 ;

            //Assert
            Assert.Equals(input, expected);
        }

        [Test]
        public void Defend_WhenHealthIsLessThan100_ShouldIncreaseHealth()
        {
            // Arrange
            Character testCharacter = new Character("Test Character", 80, inventory , 3, 1);
            Item exampleItem = new Item("Example Item ", 6 , 5 , 4); 

            // Act
            character.Defend(exampleItem);

            int output = testCharacter.HealthPoint ;

            // Assert
            Assert.GreaterOrEqual(output, 80); 
            Assert.LessOrEqual(output, 100);   
        }

        [Test]
        public void Defend_WhenHealthIs100_ShouldNotIncreaseHealth()
        {
            // Arrange
            Character testCharacter = new Character("Test Character", 100, inventory, 1, 3);
            Item exampleItem = new Item("Example Item ", 6 , 5 , 4); 

            // Act
            character.Defend(exampleItem);

            int output = testCharacter.HealthPoint ;
            int expected = 100 ;

            // Assert
            Assert.AreEqual(output, expected); 
        }

        [Test]
        public void Heal_WhenHealthIsLessThan100_ShouldIncreaseHealth()
        {
            // Arrange
            Character testCharacter = new Character("Test Character", 80, inventory, 1, 3);
            Item exampleItem = new Item("Example Item ", 6 , 5 , 4); 

            // Act
            testCharacter.Heal(exampleItem);

            int output = testCharacter.HealthPoint ;

            // Assert
            Assert.GreaterOrEqual(output, 80); // check
            Assert.LessOrEqual(output, 100);   
        }

        [Test]
        public void Heal_WhenHealthIs100_ShouldNotIncreaseHealth()
        {
            // Arrange
            Character testCharacter = new Character("Test Character", 100, inventory, 2, 2);
            Item exampleItem = new Item("Example Item ", 6 , 5 , 4); 

            // Act
            int output = testCharacter.Heal(exampleItem);
            int expected = 100 ;

            // Assert
            Assert.AreEqual(output, expected); 
        }

        [Test]
        public void Attack_ShouldNotReduceHealthBelowZero()
        {
            // Arrange
            Character testCharacter = new Character("Test Attacker", 10, inventory , 2, 2);
            Character exampleTarget = new Character("example Target", 5, inventory , 3, 1);
            Item exampleItem = new Item("Example Item ", 6 , 5 , 4); 

            // Act
            testCharacter.Attack(exampleItem, exampleTarget);

            int output = exampleTarget.HealthPoint ;
            int expected = 0 ;

            // Assert
            Assert.GreaterOrEqual(output, expected); 
        }

        //test Dwarf

        [Test]
        public void ResistanceOutOfParameters()
        {
            int input = 80;
            int expected = "";
            int output = setResistance(input);

            Assert.AreEqual(expected, output);
        }
    }
}


