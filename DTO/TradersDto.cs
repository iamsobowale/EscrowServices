namespace EscrowServices.DTO;

public class TradersDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int AccountNumber { get; set; }
    public string AccountName { get; set; }
    public string Gender { get; set; }
    public string BankName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime Dob { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
}
public class CreateTraderRequestModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Gender { get; set; }
    public string Phone { get; set; }
    public DateTime Dob { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
}
public class TradersResponseModel:BaseResponse
{
    public TradersDto Traders { get; set; }
}

public class TraderResponsesModel:BaseResponse
{
    public IEnumerable<AdminDto> Admin { get; set; }
}

public class TraderUpdateRequestModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
}