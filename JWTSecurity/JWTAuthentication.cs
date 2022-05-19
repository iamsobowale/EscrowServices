namespace EscrowServices.JWTSecurity;

public class JWTAuthentication:IJWTAuthenthication
{
    public string GenerateToken(string username, string password)
    {
        throw new NotImplementedException();
    }

    public bool ValidateToken(string token)
    {
        throw new NotImplementedException();
    }
}