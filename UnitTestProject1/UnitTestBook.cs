using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAfClassLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestBook
    {
        private Book _book;

        [TestInitialize]
        public void Init()
        {
            _book = new Book();
        }

        [TestMethod]
        public void TestAuthor()
        {
            //Act
            _book.Author = "Anders";

            //Assert
            Assert.AreEqual("Anders", _book.Author);
        }

        [TestMethod]
        public void TestPrice()
        {
            //Act
            _book.Price = 10.0/3.0;

            //Assert
            Assert.AreEqual(3.3333 ,_book.Price, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIllegalPrice()
        {
            //Act
            _book.Price = -0.01;
        }

        [TestMethod]
        public void TestToString()
        {
            //Act
            _book.Author = "John";
            _book.Title = "My first book";
            _book.Price = 9.5;
            string result = _book.ToString();
           
            //Assert
            Assert.AreEqual("John My first book 9,5", result);
        }
    }
}
