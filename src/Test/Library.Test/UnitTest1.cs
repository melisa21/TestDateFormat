using NUnit.Framework;

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
            date = testDate.Substring(6) + "-" + testDate.Substring(3, 2) + "-" + testDate.Substring(0, 2);
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("1977-11-10", date);
        }
    }
}