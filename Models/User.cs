using EscrowServices.Auditable;

namespace EscrowServices.Models;

public class User:AuditableEntity
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public Role Role { get; set; }
    public Traders Traders{get;set;}
}