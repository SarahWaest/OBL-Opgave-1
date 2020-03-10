using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave1Unit_tests;
namespace BogUnitTest
{
    [TestClass]
    public class BogTest
    {
        private Bog _bog;

        [TestInitialize]
        public void Initialize()
        {
            _bog = new Bog();
        }

        [TestMethod]
        public void TestForfatter()
        {
            //Arrange
            //Bog bog = new Bog();

            //Act
            _bog.Forfatter = "Anders Kristian Børjesson";

            //Assert
            Assert.AreEqual("Anders Kristian Børjesson", _bog.Forfatter);

            _bog.Forfatter = "Anders B";

            Assert.AreEqual("Anders B", _bog.Forfatter);
        }

        [TestMethod]
        public void TestSidetal()
        {
            //Arrange
            //Bog bog = new Bog();

            //Act
            _bog.Sidetal = 500;

            //Assert
            Assert.AreEqual(500, _bog.Sidetal);
        }

        [TestMethod]
        public void TestISBN13()
        {
            //Arrange
            //Bog bog = new Bog();

            //Act
            _bog.Isbn13 = "DetteErISBN13";

            //Assert
            Assert.AreEqual("DetteErISBN13", _bog.Isbn13);
        }

        [TestMethod]
        public void TestTitel()
        {
            //Arrange
            //Bog bog = new Bog();

            //Act
            _bog.Titel = "Nem Programmering";

            //Assert
            Assert.AreEqual("Nem Programmering", _bog.Titel);
        }

        [TestMethod]
        public void TestToString()
        {
            //Arrange
            //Bog bog = new Bog();

            //Act
            _bog.Forfatter = "Benjamin Sørensen";
            _bog.Titel = "How to get good at TFT";
            _bog.Sidetal = 50;
            _bog.Isbn13 = "blademasters";
            string result = _bog.ToString();

            //Assert
            Assert.AreEqual("Benjamin Sørensen How to get good at TFT 50 blademasters", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIllegalForfatterNavnUnder2Tegn()
        {
            //Arrange

            //Act
            _bog.Forfatter = "K";

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIllegalIsbn13Over13tegn()
        {
            //Arrange

            //Act
            _bog.Isbn13 = "HejMedDigJegHedderKaj";

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIllegalIsbn13Under13tegn()
        {
            //Arrange

            //Act
            _bog.Isbn13 = "hej";

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIllegalSidetalUnder4()
        {
            //Arrange

            //Act
            _bog.Sidetal = 1;

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIllegalSidetalOver1000()
        {
            //Arrange

            //Act
            _bog.Sidetal = 1001;

            //Assert
        }
    }
}
