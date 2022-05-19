using EscrowServices.Context;
using EscrowServices.Interfaces.IRepositries;
using EscrowServices.Models;

namespace EscrowServices.Implementation.Repositries;

public class UserRepo:BaseRepositry<User>, IUser
{
    public UserRepo(ApplicationContext context) : base(context)
    {
    }
}