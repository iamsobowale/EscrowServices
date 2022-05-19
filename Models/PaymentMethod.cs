using EscrowServices.Auditable;

namespace EscrowServices.Models;

public class PaymentMethod:BaseEntities
{
    public string Name { get; set; }
    public string Description { get; set; }
}