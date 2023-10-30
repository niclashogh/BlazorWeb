using BlazorWeb.Service;

namespace BlazorWeb.Models
{
    public class Customer : User
    {
        public string Email { get; set; }

        public Customer(string firstName, string lastName, string email)
        {
            this.FistName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Permission = UserPermission.Customer;
        }

        public Customer(string email)
        {
            Email = email;
            Permission = UserPermission.Guest;
        }
    }
}
