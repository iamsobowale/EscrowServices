using EscrowServices.Models;

namespace EscrowServices.DTO;

public class DisputeDto
{
    public int AdminId { get; set; }
    public string AdminFirstName{ get; set; }
    public string AdminLastName { get; set; }
    public string AdminTag{ get; set; }
    public int TransactionId { get; set; }
    public string Reason { get; set; }
    public string Description { get; set; }
    public bool IsResolved { get; set; }
    public string BuyerId { get; set; }
    public string SellerId { get; set; }
    public string ItemName { get; set; }
    public string ItemDescription { get; set; } 
    public decimal ItemPrice { get; set; }
    public DateTime CreatedDate { get; set; }
}