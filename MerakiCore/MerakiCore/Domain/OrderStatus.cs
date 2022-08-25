using System.ComponentModel.DataAnnotations;

namespace MerakiCore.Domain
{
    public class OrderStatus
    {
        [Key]
        public int Id { get; set; } 
        public string Status { get; set; }
    }
}
