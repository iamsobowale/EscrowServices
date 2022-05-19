using EscrowServices.Auditable;

namespace EscrowServices.Models;

public class TradersTransaction:BaseEntities
{
    public int UserId { get; set; }
    public User User { get; set; }
    public int TransactionId { get; set; }
    public Transaction Transaction { get; set; }
}