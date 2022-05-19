using EscrowServices.Models;

namespace EscrowServices.DTO;

public class TransactionDto
{
    public string BuyerId { get; set; }
    public string SellerId { get; set; }
    public string ItemName { get; set; }
    public string ItemDescription { get; set; } 
    public decimal ItemPrice { get; set; }
    public string ItemQuantity { get; set; }
    public string ItemDoc { get; set; }
    public TransactionStatus Status { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
}

public class CreateTransactionRequestModel
{
    public string BuyerId { get; set; }
    public string SellerId { get; set; }
    public string ItemName { get; set; }
    public string ItemDescription { get; set; } 
    public decimal ItemPrice { get; set; }
    public string ItemQuantity { get; set; }
    public string ItemDoc { get; set; }
}
