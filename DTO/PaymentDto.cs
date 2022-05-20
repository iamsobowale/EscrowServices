using EscrowServices.Models;

namespace EscrowServices.DTO;

public class PaymentDto
{
    public int PaymentMethodId { get; set; }
    public string PaymentMethodName { get; set; }
    public string PaymentMethodDescription { get; set; }
    public decimal Amount { get; set; }
    public Guid ReferenceNumber {get;set;}
    public DateTime PaymentDate { get; set; }
    public PaymentStatus Status { get; set; }
}
public class CreatePaymentRequestModel
{
    public int PaymentMethodId { get; set; }
    public decimal Amount { get; set; }
    public Guid ReferenceNumber { get; set; }
    public PaymentStatus Status { get; set; }
}
public class PaymentResponseModel:BaseResponse
{
    public PaymentDto Payment { get; set; }
}
public class PaymentResponsesModel:BaseResponse
{
    public IEnumerable<PaymentDto> Payments { get; set; }
}