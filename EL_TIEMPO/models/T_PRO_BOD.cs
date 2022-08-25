using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_PRO_BOD
    {
        public int PROBOD_ID { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "ID Producto Del Proveedor :")]

        [ForeignKey("T_PROVEEDOR")]
        public int PROBOD_PROPROV_ID { get; set; }

        public T_PROVEEDOR? T_PROVEEDOR  { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Producto En bodega:")]

        [ForeignKey("T_BODEGA")]
        public int PROBOD_BOD_ID { get; set; } 

        public T_BODEGA? T_BODEGA { get; set; } 
    }
}
