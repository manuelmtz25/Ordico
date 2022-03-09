using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ordico.Promos.DAL.Mocks;

namespace Ordico.Promos.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EvaluacionInicialCarritoDeCompras()
        {
            var carrito = new CarritoMock();
            Assert.IsNotNull(carrito);
            
        }
    }
}