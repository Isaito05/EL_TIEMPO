using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_BODEGA
    {
        public T_BODEGA()
        {
        }

        [Key]
        public int BOD_ID { get; set; }
        public int BOD_STOCK_MINIMO { get; set; }
        public string? BOD_ESTADO { get; set; }
    }
}
