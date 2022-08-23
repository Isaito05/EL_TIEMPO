using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_DIRECCION
    {
        public int DIR_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Tipo De Direccion")]
        public string? DIR_TIPO { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Valor De Direccion")]
        public string? DIR_VALOR { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Identificacion del usuario")]
        public int DIR_RGU_IDENTIFICACION { get; set; }
    }
}
