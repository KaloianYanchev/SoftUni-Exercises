namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;
    using System.Reflection.Metadata;
    using System.Xml.Serialization;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private Database database;

        [SetUp]
        public void SetUp()
        {
            Person[] people =
            {
                    new Person(1, "Freddy"),
                    new Person(2, "Clapton"),
                    new Person(3, "Dio"),
                    new Person(4, "Dirkschneider"),
                    new Person(5, "Hoffman"),
                    new Person(6, "Iommi"),
                    new Person(7, "Lemmy"),
                    new Person(8, "Coverdale"),
                    new Person(9, "Moore"),
                    new Person(10, "Halford"),
                    new Person(11, "Tipton"),
                    new Person(12, "Downing"),
                    new Person(13, "Cornell"),
                    new Person(14, "Mustaine"),
                    new Person(15, "Dickinson"),
            };

            database = new Database(people);
        }

        //[Test]
        //
        //public void ArrayCapacityShouldBeExactlyTheLengthOf16Integers()
        //{
        //    //Arrange
        //    int expectetResult = 15;
        //
        //    //Act
        //    database.Add(new Person(1, "asd"));
        //
        //    //Assert
        //    Assert.That(expectetResult, Is.EqualTo(database.Count));
        //}

        [Test]
        public void CountMethodShouldReturnTheCount()
        {
            //Arrange
            int expectedResult = 15;

            //Assert
            Assert.That(expectedResult, Is.EqualTo(database.Count));
        }

        [Test]
        public void AddMethodShouldAddAPersonIfCountIsLessThan16()
        {
            //Arrange
            Person person = new Person(16, "Lord");
            int expectedResult = 16;

            //Act
            database.Add(person);

            //Assert
            Assert.That(expectedResult, Is.EqualTo(database.Count));
        }

        [Test]
        public void AddMethodShouldThrowExceptionIfCountIsMoreThan16()
        {
            //Arrange
            Person person = new Person(16, "Lord");

            //Act
            database.Add(person);

            //Assert
            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(17, "Kondio")));
        }

        [Test]
        public void AddMethodShouldThrowExceptionIfPersonHasSameName()
        {
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(()
            => database.Add(new Person(16, "Freddy")));

            //Assert
            Assert.AreEqual("There is already user with this username!", exception.Message);
        }

        [Test]
        public void AddMethodShouldThrowExceptionIfPersonHasSameId()
        {
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(()
            => database.Add(new Person(1, "Wilde")));

            //Assert
            Assert.AreEqual("There is already user with this Id!", exception.Message);
        }

        [Test]
        public void RemoveMethodShouldRemoveAPersonIfCountLargerThanZero()
        {
            //Arrange
            int expectedResult = 14;
            //Act
            database.Remove();

            //Assert
            Assert.AreEqual(expectedResult, database.Count);
        }

        [Test]
        public void RemoveMethodShouldThrowAnExceptionIfCountIsEqualOrBelowZero()
        {
            //Arrange
            database = new Database();
        
            //Act
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(()
            => database.Remove());
        }

        [TestCase("")]
        [TestCase(null)]
        public void FindByUsernameMethodShouldThrowAnExceptionIfNameEmptyOrNull(string name)
        {
            //Act
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(()
            => database.FindByUsername(name));

            Assert.AreEqual("Username parameter is null!", exception.ParamName);
        }

        [TestCase("Dubioza")]
        [TestCase("BonJovi")]
        public void FindByUsernameMethodShouldThrowAnExceptionIfNameIsntInTheDataBase(string name)
        {
            //Act
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(()
            => database.FindByUsername(name));

            Assert.AreEqual("No user is present by this username!", exception.Message);
        }

        [TestCase("Freddy")]
        [TestCase("Dio")]
        public void FindByUsernameMethodShouldFindPersonIfHeIsInTheCollection(string name)
        {
            //Arrange
            string expectedResult = name;
            string actualResult = database.FindByUsername(name).UserName;

            //Arrange
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(-1)]
        [TestCase(-100)]
        public void FindByIdMethodShouldThrowAnExceptionIfIdIsBelowZero(long id)
        {
            //Act
            ArgumentOutOfRangeException exception = Assert.Throws<ArgumentOutOfRangeException>(()
            => database.FindById(id));

            Assert.AreEqual("Id should be a positive number!", exception.ParamName);
        }

        [TestCase(25)]
        [TestCase(1000)]
        public void FindByIdMethodShouldThrowAnExceptionIfIdIsntInTheDataBase(long id)
        {
            //Act
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(()
            => database.FindById(id));

            Assert.AreEqual("No user is present by this ID!", exception.Message);
        }

        [TestCase(1)]
        [TestCase(15)]
        public void FindByIdMethodShouldFindUserById(long id)
        {
            //Arrange
            long expectedResult = id;
            long actualResult = database.FindById(id).Id;


            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}