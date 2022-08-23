using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_DIRECCION_PROV
    {
        public int DIRPROV_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Tipo De Direccion")]
        public string? DIRPROV_TIPO { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Valor De Direccion")]
        public string? DIRPROV_VALOR { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Id del Proovedor")]
        public int DIRPROV_PROV_ID { get; set; }
    }
}
