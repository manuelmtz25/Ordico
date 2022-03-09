using Ordico.Promos.DAL.Mocks;

namespace Ordico.Promos.BLL
{
    public class Carrito
    {
        public CarritoMock ObtenerCompraCarrito()
        {
            var carrito = new CarritoMock();
            return carrito;
        }
    }
}
