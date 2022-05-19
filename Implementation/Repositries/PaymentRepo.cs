using EscrowServices.Context;
using EscrowServices.Interfaces.IRepositries;
using EscrowServices.Models;

namespace EscrowServices.Implementation.Repositries;

public class PaymentRepo:BaseRepositry<Payment>,IPayment
{
    public PaymentRepo(ApplicationContext context) : base(context)
    {
    }
}