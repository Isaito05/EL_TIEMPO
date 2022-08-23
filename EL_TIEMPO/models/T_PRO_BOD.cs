using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_PRO_BOD
    {
        public int PROBOD_ID { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "ID Producto Del Proveedor :")]
        public int PROBOD_PROPROV_ID { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Producto En Bodega:")]
        public int PROBOD_BOD_ID { get; set; } 
    }
}
