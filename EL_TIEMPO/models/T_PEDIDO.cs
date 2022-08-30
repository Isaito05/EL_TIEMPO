using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MI_TERRAZA.Models
{
    [Table("T_PEDIDO")]
    public class T_PEDIDO
    {
        [Key]
        public int PED_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Estado Del Pedido :")]
        public string? PED_ESTADO { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "ID Del Cliente :")]
        [ForeignKey("T_CLIENTE")]
        public int PED_CLI_ID { get; set; }

        public T_CLIENTE? T_CLIENTE { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Fecha Del Pedido :")]
        public DateTime PED_FECHA { get; set; }
    }
}
