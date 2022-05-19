using EscrowServices.Context;
using EscrowServices.Interfaces.IRepositries;
using EscrowServices.Models;

namespace EscrowServices.Implementation.Repositries;

public class AdminRepo:BaseRepositry<Admin>, IAdmin
{
    public AdminRepo(ApplicationContext context) : base(context)
    {
    }
}