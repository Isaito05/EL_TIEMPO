using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_CLIENTE
    {
        [Key]
        [Display(Name ="Id del cliente :")]
        public int CLI_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name ="Identificacion Del Usuario :")]
        public int CLI_RGU_IDENTIFICACION { get; set; }
    }
}
