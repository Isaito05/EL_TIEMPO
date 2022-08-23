namespace MI_TERRAZA.Models
{
    public class T_PRESTAMO
    {
        public int PRES_ID { get; set; }
        public DateTime PRES_FECHA { get; set; }
        public int PRES_MONTO { get; set; }
        public string PRES_ESTADO { get; set; } = null!;
        public string PRES_MON_RESTANTE { get; set; } = null!;
    }
}
