using System;
using System.ComponentModel.DataAnnotations;

namespace MerakiCore.Domain
{
    public class Catalog
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] File { get; set; }
        public DateTime UploatedDate { get; set; }
    }
}
