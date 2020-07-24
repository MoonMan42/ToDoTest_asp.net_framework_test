using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace ToDoTest.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ToDoModel> ToDoList { get; set; } // connection to db

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}