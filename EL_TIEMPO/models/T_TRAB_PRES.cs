using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MI_TERRAZA.Models
{
        [Table("T_TRAB_PRES")]
    public class T_TRAB_PRES
    {
        [Key]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int TRABPRES_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name ="Id del trabajador")]
        [ForeignKey("T_TRABAJADOR")]
        public int TRABPRES_TRAB_ID { get; set; }

        public T_TRABAJADOR? T_TRABAJADOR { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name ="Id del prestamo")]
        [ForeignKey("T_PRESTAMO")]
        public int TRABPRES_PRES_ID { get; set; }

        public T_PRESTAMO? T_PRESTAMO { get; set; }


    }
}
