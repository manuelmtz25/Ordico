namespace Ordico.Promos.DAL.Entidades
{
    public class CriteriosPromocionPorItem
    {
        public string SKU { get; set; }
        public int Cantidad { get; set; }
        public bool BeneficioUnico { get; set; }
        public bool CantidadDeCompra { get; set; }
    }
}
