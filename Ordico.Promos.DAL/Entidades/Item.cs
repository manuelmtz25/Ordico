namespace Ordico.Promos.DAL.Entidades
{
    public class Item
    {
        public string SKU { get; set; }
        public string Descipcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public Catalogo.GrupoProductos GrupoAlQuePertenece { get; set; }
    }
}
