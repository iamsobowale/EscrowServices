using EscrowServices.Models;

namespace EscrowServices.DTO;

public class UserDto
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public Role Role { get; set; }
}

public class UserLoginRequest
{
    public string UserName{get; set;}
    public string Password{get; set;}
}
public class UserResponseModel : BaseResponse
{
    public UserDto Data{get;set;}
}
public class UsersResponseModel : BaseResponse
{
    public List<UserDto> Data{get;set;}
}