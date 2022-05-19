using EscrowServices.Auditable;

namespace EscrowServices.Models;

public class Payment:AuditableEntity
{
    public int PaymentMethodId { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public decimal Amount { get; set; }
    public Guid ReferenceNumber {get;set;}
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public PaymentStatus Status { get; set; }
    public int TransactionId { get; set; }
    public Transaction Transaction { get; set; }
}