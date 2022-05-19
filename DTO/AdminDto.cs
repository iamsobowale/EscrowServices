using EscrowServices.Models;

namespace EscrowServices.DTO;

public class AdminDto
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
    public IEnumerable<Dispute> Disputes { get; set; }
}