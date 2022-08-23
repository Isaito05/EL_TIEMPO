using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_CORREO
    {
        [Key]
        public int COR_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [EmailAddress(ErrorMessage = "Este campo debe contener @example.com")]
        [Display(Name ="Correo :")]
        public string COR_DIRECCION { get; set; } = null!;
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name ="Identificacion :")]
        public int COR_RGU_IDENTIFICACION { get; set; }
    }
}
