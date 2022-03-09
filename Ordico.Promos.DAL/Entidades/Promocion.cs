namespace Ordico.Promos.DAL.Entidades
{
    public class Promocion
    {
        public Guid Id { get; set; }
        public DateOnly FechaInicio { get; set; }
        public TimeOnly HoraInicio { get; set; }
        public DateOnly FechaFin { get; set; }
        public TimeOnly HoraFin { get; set; }
        public bool EventoUnico { get; set; }
        public string DiasPromocion { get; set; }
    }
}
