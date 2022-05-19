using EscrowServices.Auditable;

namespace EscrowServices.Models;

public class PaymentMethod:AuditableEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
}