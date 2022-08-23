using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_TRAB_PRES
    {
        [Key]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int TRABPRES_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name ="Id del trabajador")]
        public int TRABPRES_TRAB_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name ="Id del prestamo")]
        public int TRABPRES_PRES_ID { get; set; }

    }
}
