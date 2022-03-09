namespace Ordico.Promos.DAL.Entidades
{
    public class CarritoDeCompras
    {
        public DateTime MomentoDeCompra { get; set; }
        public Item ListaDeProductos { get; set; }

        public decimal TotalDeCompra { get; set; }
    }
}
