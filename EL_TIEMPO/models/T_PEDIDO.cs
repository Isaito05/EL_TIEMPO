using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_PEDIDO
    {
        public int PED_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Estado Del Pedido :")]
        public string? PED_ESTADO { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "ID Del Cliente :")]
        public int PED_CLI_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Fecha Del Pedido :")]
        public DateTime PED_FECHA { get; set; }
    }
}
