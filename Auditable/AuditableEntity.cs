namespace EscrowServices.Auditable;

public abstract class AuditableEntity:Address,BaseEntities
{
    public bool IsSuspended { get; set; }
    public bool IsDeleted{ get; set; }
    public string AddressLine1 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public int Id { get; set; }
}