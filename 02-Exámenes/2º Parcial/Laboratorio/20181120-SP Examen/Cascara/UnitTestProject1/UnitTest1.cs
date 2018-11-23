using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sobrecargas()
        {
            Tren tren = new Tren();

            try
            {
                tren += -1;
            }
            catch(CantidadInvalidaException ex)
            {
                
            }
            catch(Exception exep)
            {
                Assert.Fail();
            }
        }
    }
}
