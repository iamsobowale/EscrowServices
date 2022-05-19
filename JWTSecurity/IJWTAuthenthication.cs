namespace EscrowServices.JWTSecurity;

public interface IJWTAuthenthication
{
    string GenerateToken(string username, string password);
    bool ValidateToken(string token);
}