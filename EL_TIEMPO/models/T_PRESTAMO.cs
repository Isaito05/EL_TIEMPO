using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_PRESTAMO
    {
        public int PRES_ID { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Fecha Del Prestamo :")]
        public DateTime PRES_FECHA { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Monto Del Prestamo :")]
        public int PRES_MONTO { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Estado Del Estado :")]
        public string PRES_ESTADO { get; set; } = null!;

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Monto Restante :")]
        public string PRES_MON_RESTANTE { get; set; } = null!;
    }
}
