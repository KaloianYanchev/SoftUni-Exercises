namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class WarriorTests
    {
        private Warrior warrior;

        [SetUp]
        public void SetUp()
        {
            warrior = new Warrior("Spartacus", 50, 200);
        }

        [TestCase("Spartacus", 50, 200)]
        public void ConstructorShouldInitializeProperly(string name, int damage, int health)
        {
            Assert.AreEqual(name, warrior.Name);
            Assert.AreEqual(damage, warrior.Damage);
            Assert.AreEqual(health, warrior.HP);
        }

        [TestCase("", 50, 200)]
        [TestCase(" ", 50, 200)]
        [TestCase(null, 50, 200)]
        public void NameShouldNotBeNullOrWhiteSpace(string name, int damage, int health)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() 
                => new Warrior(name, damage, health));

            Assert.AreEqual("Name should not be empty or whitespace!", exception.Message);
        }

        [TestCase("Spartacus", 0, 200)]
        [TestCase("Spartacus", -100, 200)]
        public void DamageShouldNotBeNullLessOrEqualThanZero(string name, int damage, int health)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(()
                => new Warrior(name, damage, health));

            Assert.AreEqual("Damage value should be positive!", exception.Message);
        }


        [TestCase("Spartacus", 50, -15)]
        public void HealthShouldNotBeNullLessThanZero(string name, int damage, int health)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(()
                => new Warrior(name, damage, health));

            Assert.AreEqual("HP should not be negative!", exception.Message);
        }

        [TestCase("Attacker", 50, 29)]
        [TestCase("Attacker", 50, 30)]
        public void AttackingWarriorShouldNotHaveLessThan30Hp(string name, int damage, int health)
        {
            //Arrange
            Warrior atackingWarrior = new Warrior(name, damage, health);
            Warrior defendingWarrior = warrior;

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(()
                => atackingWarrior.Attack(defendingWarrior));

            Assert.AreEqual("Your HP is too low in order to attack other warriors!", exception.Message);
        }

        [TestCase("Defender", 50, 29)]
        [TestCase("Defender", 50, 30)]
        public void DefendingWarriorShouldNotHaveLessThan30Hp(string name, int damage, int health)
        {
            //Arrange
            Warrior atackingWarrior = warrior;
            Warrior defendingWarrior = new Warrior(name, damage, health);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(()
                => atackingWarrior.Attack(defendingWarrior));

            Assert.AreEqual($"Enemy HP must be greater than {30} in order to attack him!", exception.Message);
        }

        [TestCase("Defender", 250, 200)]
        public void AttackingWarriorShouldHaveMoreHealthThanTheDefendingWarriorDamage(string name, int damage, int health)
        {
            //Arrange
            Warrior atackingWarrior = warrior;
            Warrior defendingWarrior = new Warrior(name, damage, health);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(()
                => atackingWarrior.Attack(defendingWarrior));

            Assert.AreEqual("You are trying to attack too strong enemy", exception.Message);
        }

        [TestCase("Defender", 30, 200)]
        public void WarriorShouldLooseHealthWhenAttackingTheDefendingWarrior(string name, int damage, int health)
        {
            //Arrange
            int expectedResult = 170;
            Warrior attackingWarrior = warrior;
            Warrior defendingWarrior = new Warrior(name, damage, health);

            //Act
            attackingWarrior.Attack(defendingWarrior);

            Assert.AreEqual(expectedResult, attackingWarrior.HP);
        }

        [TestCase("Defender", 30, 200)]
        public void DefenderShouldLooseHeathWhenAttacked(string name, int damage, int health)
        {
            //Arrange
            int expectedResult = 150;
            Warrior attackingWarrior = warrior;
            Warrior defendingWarrior = new Warrior(name, damage, health);

            //Act
            attackingWarrior.Attack(defendingWarrior);

            Assert.AreEqual(expectedResult, defendingWarrior.HP);
        }

        [TestCase("Defender", 30, 40)]
        [TestCase("Defender", 30, 50)]
        public void DefenderShouldSetHealthToZeroIfAttackerDamageIsLargerOrEqualThanHisHealth(string name, int damage, int health)
        {
            //Arrange
            int expectedResult = 0;
            Warrior attackingWarrior = warrior;
            Warrior defendingWarrior = new Warrior(name, damage, health);

            //Act
            attackingWarrior.Attack(defendingWarrior);

            Assert.AreEqual(expectedResult, defendingWarrior.HP);
        }
    }
}