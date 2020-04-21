using System;
using NUnit.Framework;

namespace Library.Test
{
    public class Tests2
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        //recibe MM-DD-AAAA o AAAA-DD-MM
        public void TestCambiaFormato([Values("XX-XX-XXXX","XXXX-XX-XX") ] String x)
        {
            Assert.AreEqual(Date.ChangeFormatDMA(x),"XX-XX-XXXX");
        }

        [Test]
        public void TestSeparadorBarra([Values("XX/XX/XXXX","XXXX/XX/XX") ] String x)
        {
            Assert.AreEqual(Date.ChangeFormatDMA(x),"XX/XX/XXXX");
        }

        [Test]
        public void TestFormatoNoValido([Values("/XX/XXXX","XXXX//XX", "XXXX//", "//") ] String x)
        {
            Assert.AreEqual(Date.ChangeFormatDMA(x),"");
        }


    }
}