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
            Wizard testCharacter = new Wizard ("Test Character", 100);
            
            int input = testCharacter.GetHealthPoint() ;
            int expected = 100 ;

            //Assert
            Assert.Equals(input, expected);
        }

        [Test]
        public void Heal_WhenHealthIsLessThan100_ShouldIncreaseHealth()
        {
            // Arrange
            Dwarf testCharacter = new Dwarf("Test Character", 80);
            BandAid exampleItem = new BandAid("Example Item "); 

            // Act
            testCharacter.Heal(exampleItem);

            int output = testCharacter.GetHealthPoint() ;

            // Assert
            Assert.GreaterOrEqual(output, 80);  
        }

        [Test]
        public void Heal_WhenHealthIs100_ShouldNotIncreaseHealth()
        {
             // Arrange
            Dwarf testCharacter = new Dwarf("Test Character", 80);
            BandAid exampleItem = new BandAid("Example Item "); 

            // Act
            testCharacter.Heal(exampleItem);

            int output = testCharacter.GetHealthPoint() ;

            // Assert 
            Assert.LessOrEqual(output, 100);
        }

        [Test]
        public void Attack_ShouldNotReduceHealthBelowZero()
        {
            // Arrange
            Character testCharacter = new Character("Test Attacker", 100);
            Character exampleTarget = new Character("example Target", 5);
            Staff exampleItem = new Staff("Example Item "); 

            // Act
            testCharacter.Attack(exampleItem, exampleTarget);

            int output = exampleTarget.GetHealthPoint() ;
            int expected = 0 ;

            // Assert
            Assert.GreaterOrEqual(output, expected); 
        }

        //test Dwarf

        [Test]
        public void ResistanceIsValid()
        {
            Dwarf = new Dwarf("ExampleCharacter",100)

            int output = Dwarf.GetResistance();
            int expected = 10;

            Assert.AreEqual(expected, output);
        }
    }
}