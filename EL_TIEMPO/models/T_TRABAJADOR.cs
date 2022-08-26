using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MI_TERRAZA.Models
{
    [Table("T_TRABAJADOR")]
    public class T_TRABAJADOR
    {

        [Key]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int TRAB_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Identificacion")]
        [ForeignKey("T_RGU_USUARIO")]
        public int TRAB_RGU_IDENTIFICACION { get; set; }

        public  T_RGU_USUARIO? T_RGU_USUARIO {get; set;}

    }
}
