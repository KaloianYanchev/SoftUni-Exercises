namespace UniversityLibrary.Test
{
    using NUnit.Framework;
    using System;
    using System.Text;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TextBookConstructorShouldWorkAsIntended()
        {
            TextBook textBook = new TextBook("Numbers", "Pesho", "Mathematics");

            Assert.IsNotNull(textBook);
            Assert.AreEqual("Numbers", textBook.Title);
            Assert.AreEqual("Pesho", textBook.Author);
            Assert.AreEqual("Mathematics", textBook.Category);
            Assert.AreEqual(0, textBook.InventoryNumber);
            Assert.AreEqual(null, textBook.Holder);
        }


        [Test]
        public void LibraryConstructorShouldWorkAsIntended()
        {
            UniversityLibrary universityLibrary = new UniversityLibrary();

            Assert.IsNotNull(universityLibrary);
            Assert.IsNotNull(universityLibrary.Catalogue);
        }

        [Test]
        public void AddBookShouldIncreaseCountAndGiveInventoryNumber()
        {
            UniversityLibrary universityLibrary = new UniversityLibrary();
            TextBook textBook = new TextBook("Numbers", "Tosho", "Mathematics");
            universityLibrary.AddTextBookToLibrary(textBook);

            Assert.AreEqual(1, universityLibrary.Catalogue.Count);
            Assert.IsTrue(universityLibrary.Catalogue.Contains(textBook));
            Assert.AreEqual(1, textBook.InventoryNumber);
        }

        [Test]
        public void AddBookShouldReturnTextBookToStringMethod()
        {
            UniversityLibrary universityLibrary = new UniversityLibrary();
            TextBook textBook = new TextBook("Numbers", "Tosho", "Mathematics");
            //universityLibrary.AddTextBookToLibrary(textBook);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Book: Numbers - 1");
            sb.AppendLine($"Category: Mathematics");
            sb.AppendLine($"Author: Tosho");
            string expectedResult = sb.ToString().TrimEnd();

            Assert.AreEqual(expectedResult, universityLibrary.AddTextBookToLibrary(textBook));

        }

        [TestCase("Pesho")]
        [TestCase("Gosho")]

        public void LoanBookShouldNotGiveBookIfStudentHasIt(string studentName)
        {
            UniversityLibrary universityLibrary = new UniversityLibrary();
            TextBook textBook = new TextBook("Numbers", "Tosho", "Mathematics");
            universityLibrary.AddTextBookToLibrary(textBook);
            string expectedResult = $"{studentName} still hasn't returned {"Numbers"}!";


            universityLibrary.LoanTextBook(1, studentName);

            Assert.AreEqual(expectedResult, universityLibrary.LoanTextBook(1, studentName));
            Assert.AreEqual(studentName, textBook.Holder);
        }

        [TestCase("Pesho")]
        [TestCase("Gosho")]

        public void LoanBookShouldWorkAsIntended(string studentName)
        {
            UniversityLibrary universityLibrary = new UniversityLibrary();
            TextBook textBook = new TextBook("Numbers", "Tosho", "Mathematics");
            universityLibrary.AddTextBookToLibrary(textBook);

            string expectedResult = $"{"Numbers"} loaned to {studentName}.";

            Assert.AreEqual(expectedResult, universityLibrary.LoanTextBook(1, studentName));
            Assert.AreEqual(studentName, textBook.Holder);
        }

        [TestCase("Pesho")]
        [TestCase("Gosho")]

        public void ReturnBookShouldNotChangeTextBookHolderIfNull(string studentName)
        {
            UniversityLibrary universityLibrary = new UniversityLibrary();
            TextBook textBook = new TextBook("Numbers", "Tosho", "Mathematics");
            universityLibrary.AddTextBookToLibrary(textBook);
            string expectedResult = $"{"Numbers"} is returned to the library.";

            universityLibrary.LoanTextBook(1, studentName);

            Assert.AreEqual(expectedResult, universityLibrary.ReturnTextBook(1));
            Assert.AreEqual(textBook.Holder, "");
        }


    }
}