using System;

namespace MerakiCore.Domain
{
    public class OrderStatusTimeLine
    {
        public int OrderId { get; set; }
        public int StatusId { get; set; }
        public DateTime StatusDate { get; set; }

    }
}
