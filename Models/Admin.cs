using EscrowServices.Auditable;

namespace EscrowServices.Models
{
    public class Admin:AuditableEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string AdminId { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public DateTime Dob { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public IEnumerable<Dispute> Disputes { get; set; }
    }
}