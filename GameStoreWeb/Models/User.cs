using System.ComponentModel;

namespace GameStoreWeb.Models
{
    public enum Role
    {
        Admin,
        Client
    }

    public class User
    {
        public int ID { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("E-Mail Address")]
        public required string Email { get; set; }

        [DisplayName("User Type")]
        public required Role Role { get; set; }
    }
}
