namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ArenaTests
    {
        private Arena arena;

        [SetUp]
        public void SetUp()
        {
            arena = new Arena();
        }

        [Test]
        public void ConstructorShouldInitializeCorrectly()
        {
            Assert.That(arena, Is.Not.Null);
        }

        [Test]
        public void CountShouldReturnTheCountOfWarriors()
        {
            Assert.That(arena.Count, Is.EqualTo(0));
        }

        [TestCase("Spartacus", 50, 200)]
        public void EnrollMethodShouldNotAddTheSameWarriors(string name, int damage, int health)
        {
            //Arrange
            Warrior warrior = new Warrior(name, damage, health);
            arena.Enroll(warrior);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(()
                => arena.Enroll(warrior));

            Assert.AreEqual("Warrior is already enrolled for the fights!", exception.Message);
        }

        [TestCase("Spartacus", 50, 200)]
        public void EnrollMethodShouldWorkAsIntended(string name, int damage, int health)
        {
            //Arrange
            Warrior warrior = new Warrior(name, damage, health);
            arena.Enroll(warrior);
            arena.Enroll(new Warrior("Petkan", 50 ,200));

            Assert.AreEqual(arena.Count, 2);
        }

        [TestCase("Spartacus", "Tosho")]
        public void FightMethodShouldThrowAnExeptionIfTheAttackerIsMissing(string attackerName, string defenderName)
        {
            //Arrange
            Warrior attacker = new Warrior("Petkan", 50, 200);
            Warrior defender = new Warrior("Tosho", 50, 200);

            arena.Enroll(attacker);
            arena.Enroll(defender);

            //Act
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(()
                => arena.Fight(attackerName, defenderName));

            Assert.AreEqual($"There is no fighter with name {attackerName} enrolled for the fights!",
                exception.Message);

        }

        [TestCase("Tosho", "Spartacus")]
        public void FightMethodShouldThrowAnExeptionIfTheDefenderIsMissing(string attackerName, string defenderName)
        {
            //Arrange
            Warrior attacker = new Warrior("Petkan", 50, 200);
            Warrior defender = new Warrior("Tosho", 50, 200);

            arena.Enroll(attacker);
            arena.Enroll(defender);

            //Act
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(()
                => arena.Fight(attackerName, defenderName));

            Assert.AreEqual($"There is no fighter with name {defenderName} enrolled for the fights!",
                exception.Message);
        }

        [TestCase("Crixus", "Spartacus")]
        public void FightMethodShouldThrowAnExeptionBothWarriorsAreMissing(string attackerName, string defenderName)
        {
            //Arrange
            Warrior attacker = new Warrior("Petkan", 50, 200);
            Warrior defender = new Warrior("Tosho", 50, 200);

            arena.Enroll(attacker);
            arena.Enroll(defender);

            //Act
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(()
                => arena.Fight(attackerName, defenderName));

            Assert.AreEqual($"There is no fighter with name {defenderName} enrolled for the fights!",
                exception.Message);
        }

        [TestCase("Petkan", "Tosho")]
        public void FightMethodShouldWorkAsIntended(string attackerName, string defenderName)
        {
            //Arrange
            Warrior attacker = new Warrior("Petkan", 50, 200);
            Warrior defender = new Warrior("Tosho", 50, 200);

            int expectedResult = 150;

            arena.Enroll(attacker);
            arena.Enroll(defender);

            //Act
            arena.Fight(attackerName, defenderName);

            Assert.That(expectedResult == attacker.HP);
            Assert.That(expectedResult == defender.HP);
        }
    }
}
