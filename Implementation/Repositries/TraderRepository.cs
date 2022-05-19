using EscrowServices.Context;
using EscrowServices.Interfaces.IRepositries;
using EscrowServices.Models;

namespace EscrowServices.Implementation.Repositries;

public class TraderRepository:BaseRepositry<Traders>, ITraders
{
    public TraderRepository(ApplicationContext context) : base(context)
    {
    }
}