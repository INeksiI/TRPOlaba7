using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace DolznostTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DolznostTest()
        {
            string Name = "Manager";
            double oklad = 7.3;
            string podraz = "Menedzhment";
            Dolznost account = new Dolznost(Name, oklad, podraz);

        }
    }
}
