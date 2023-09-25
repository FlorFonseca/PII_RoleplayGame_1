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
            Assert.AreEqual(input, expected);
        }

        [Test]
        public void Heal_WhenHealthIsLessThan100_ShouldIncreaseHealth()
        {
            // Arrange
            Dwarf testCharacter = new Dwarf("Test Character", 80);
            BandAid exampleItem = new BandAid("Example Item "); 

            // Act
            testCharacter.Heal(exampleItem,testCharacter);

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
            testCharacter.Heal(exampleItem,testCharacter);

            int output = testCharacter.GetHealthPoint() ;

            // Assert 
            Assert.LessOrEqual(output, 100);
        }

        [Test]
        public void Attack_ShouldNotReduceHealthBelowZero()
        {
            // Arrange
            Elf testCharacter = new Elf("Test Attacker", 100);
            Dwarf exampleTarget = new Dwarf("example Target", 5);
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
            Dwarf testCharacter = new Dwarf("ExampleCharacter",100);

            int output = testCharacter.GetResistance();
            int expected = 10;

            Assert.AreEqual(expected, output);
        }
    }
}