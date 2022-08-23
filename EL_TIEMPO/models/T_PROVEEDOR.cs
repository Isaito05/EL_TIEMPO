using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_PROVEEDOR
    {
        [Key]
        public int PROV_ID { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Nombre Del Proveedor : :")]
        public string PROV_NOMBRE { get; set; } = null!;
    }
}
