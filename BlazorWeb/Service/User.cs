using BlazorWeb.Models;

namespace BlazorWeb.Service
{
    public abstract class User
    {
        public int Id { get; set; }
        public string? FistName { get; set; }
        public string? LastName { get; set; }

        public virtual UserPermission Permission { get; set; }
    }
}
