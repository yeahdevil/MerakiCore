using System.ComponentModel.DataAnnotations;

namespace MerakiCore.Domain
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public byte[] Image { get; set; }
        public int StatusId { get; set; }
        public int PlacedOn { get; set; }
        public int ClosedOn { get; set; }
    }
}
