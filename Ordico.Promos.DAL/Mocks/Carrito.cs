using Ordico.Promos.DAL.Entidades;

namespace Ordico.Promos.DAL.Mocks
{
    public class Carrito
    {
        public Carrito()
        {
            var carritoDeCompras = new CarritoDeCompras();
            carritoDeCompras.MomentoDeCompra=DateTime.Now;
            var listaCompras = new List<Item>()
            {
                new Item() { Cantidad = 2, Descipcion = "Sabritas", GrupoAlQuePertenece = Catalogo.GrupoProductos.Abarrotes, PrecioUnitario = 10, SKU = "ABC01" },
                new Item() { Cantidad = 3, Descipcion = "Coca-Cola", GrupoAlQuePertenece = Catalogo.GrupoProductos.Bebidas, PrecioUnitario = 10, SKU = "ABC01" },
                new Item() { Cantidad = 1, Descipcion = "Papel", GrupoAlQuePertenece = Catalogo.GrupoProductos.Abarrotes, PrecioUnitario = 10, SKU = "ABC01" },
                new Item() { Cantidad = 4, Descipcion = "Jugo", GrupoAlQuePertenece = Catalogo.GrupoProductos.Salud, PrecioUnitario = 10, SKU = "ABC01" },
            };
            carritoDeCompras.TotalDeCompra = 5000;
        }
    }
}
