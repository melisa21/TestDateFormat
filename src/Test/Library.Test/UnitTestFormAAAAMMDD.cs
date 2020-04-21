using NUnit.Framework;
using Library;

namespace Library.Test
{
    public class Tests
    {

        private string date;
        [SetUp]
        public void Setup()
        {
            string testDate = "10/11/1977";
            //devuelve la fecha en formato “aaaa­‐mm­‐dd”
            date = Date.ChangeFormatAMD(testDate);
            
        }

        [Test]
        public void TestCantidaDig()
        {
            Assert.AreEqual("1977-11-10", date);
        }

        
        [Test]
        public void TestDia1Dig()
        {
            Assert.AreNotEqual("1977-11-1", date);
        }

        [Test]

        public void TestMes1Dig()
        {
            Assert.AreNotEqual("1977-1-10", date);
        }


    }
}