using EscrowServices.Context;
using EscrowServices.Interfaces.IRepositries;
using EscrowServices.Models;

namespace EscrowServices.Implementation.Repositries;

public class DisputeRepo:BaseRepositry<Dispute>, IDispute
{
    public DisputeRepo(ApplicationContext context) : base(context)
    {
    }
}