using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestStudent
    {
        private Student _student;

        [TestInitialize]
        public void Init()
        {
            _student = new Student();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestName()
        {
            //Act
            _student.Name = "h";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddress()
        {
            //Act
            _student.Address = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSemesterMoreThanAllowed()
        {
            //Act
            _student.Semester = 10;        
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSemesterLessThanAllowed()
        {
            //Act
            _student.Semester = 0;
        }

        [TestMethod]
        public void TestGender()
        {
            //Act
            _student.Gender = Gender.Male;

            //
            Assert.AreEqual(Gender.Male, _student.Gender);
        }

    }
}
