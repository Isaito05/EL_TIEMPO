using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_CORREO_PROV
    {
        [Key]
        [Required(ErrorMessage ="Este campo es obligatorio")]
        public int CORPROV_ID { get; set; }
        [EmailAddress(ErrorMessage = "Este campo debe contener @example.com")]
        [Display(Name = "Correo :")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string CORPROV_DIRECCION { get; set; } = null!;
    }
}
