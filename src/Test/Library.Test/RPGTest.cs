using NUnit.Framework;

namespace Test.Library
{
    public class RPGTest
    {
        [Test]
        public void ValidHealthPoint()
        {
            int input = character.HealthPoint ;
            int expected = 100 ;
            Assert.Equals(input, expected); //test incorrecto pero me sirve como base
        }
    }
}