

using EscrowServices.Context;
using EscrowServices.Interfaces.IRepositries;
using EscrowServices.Models;

namespace EscrowServices.Implementation.Repositries;

public class TransactionRepo:BaseRepositry<Transaction>, ITransaction
{
    public TransactionRepo(ApplicationContext context) : base(context)
    {
    }
}