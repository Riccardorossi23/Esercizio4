using System;
using Esercizio4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTemperature
{
    [TestClass]
    public class TempLibraryTest
    {
        [TestMethod]
        public void TestTemperature1()
        {
            double[] temp1 = new double[] { 28, 20.5, 13, 25.3 };
            double risultato = Temperatura.MediaTemperature(temp1);
            Assert.IsNotNull(risultato);

        }
        [TestMethod]
        public void TestTemperature2()
        {
            double[] temp1 = new double[] { 25,23.5,33,15.3 };
            double risultato = Temperatura.MediaTemperature(temp1);
            Assert.IsNotNull(risultato);


        }
     
    }
}
