using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MI_TERRAZA.Models
{
    public class T_CLIENTE
    {
        [Key]
        [Display(Name ="Id del cliente :")]
        public int CLI_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name ="Identificacion Del Usuario :")]
        
        [ForeignKey("T_RGU_USUARIO")]
        public int CLI_RGU_IDENTIFICACION { get; set; }
        public T_RGU_USUARIO? T_RGU_USUARIO { get; set; }
    }
}
