using EscrowServices.Auditable;

namespace EscrowServices.Models
{
    public class Traders:BaseEntities
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
        public int UserId{get;set;}
        public User User{get;set;}
        public IEnumerable<TradersTransaction> TradersTransactions { get; set; } = new List<TradersTransaction>();
    }
}