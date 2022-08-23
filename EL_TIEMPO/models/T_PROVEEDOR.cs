using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_PROVEEDOR
    {
        [Key]
        public int PROV_ID { get; set; }
        public string PROV_NOMBRE { get; set; } = null!;
    }
}
