using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        [TestCase(100, 100, 50, 50)]
        [TestCase(100, 100, 100, 0)] //- should not work
        [TestCase(100, 100, 60, 40)]
        [TestCase(100, 100, 90, 10)]
        public void DummyShouldLooseHealthWhenAttacked(int dummyHealth, int dummyExperience, int damageDone, int expectedHealth)
        {
            //Arrange
            Dummy dummy = new Dummy(dummyHealth, dummyExperience);

            //Act
            dummy.TakeAttack(damageDone);

            //Assert
            Assert.That(dummy.Health, Is.EqualTo(expectedHealth));
        }

        [Test]
        public void DummyShouldThrowAnExceptionIfAttackedIfIsDead()
        {
            //Arrange
            Dummy dummy = new Dummy(100, 100);
        
            //Act
            dummy.TakeAttack(100);
        
            //Assert
            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(50), "Dummy is dead");
        }

        [Test]
        [TestCase(100, 100)]

        public void DummyShouldNotGiveExperienceIfNotDead(int dummyHealth, int dummyExperience)
        {
            //Arrange
            Dummy dummy = new Dummy(dummyHealth, dummyExperience);

            //Act
            dummy.TakeAttack(99);

            //Assert
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }

        [Test]
        [TestCase(100, 100)]

        public void DummyShouldGiveExperienceIfDead(int dummyHealth, int dummyExperience)
        {
            //Arrange
            Dummy dummy = new Dummy(dummyHealth, dummyExperience);

            //Act
            dummy.TakeAttack(100);

            //Assert
            Assert.That(dummy.GiveExperience(), Is.EqualTo(dummyExperience));
        }
    }
}