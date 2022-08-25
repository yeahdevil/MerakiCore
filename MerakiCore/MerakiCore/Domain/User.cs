using LinqToDB.Mapping;

namespace MerakiCore.Domain
{

    [Table(Name = "Users")]
    public class User
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }
        [Column]
        public string Name { get; set; }
        [Column]
        public string UserName { get; set; }
        [Column]
        public string Passowrd { get; set; }
        [Column]
        public string Email { get; set; }
        [Column]
        public string PhoneNumber { get; set; }
        [Column]
        public bool IsEmailConfirmed { get; set; }
        [Column]
        public bool IsActive { get; set; }
    }
}
