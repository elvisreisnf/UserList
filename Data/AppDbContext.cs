using Microsoft.EntityFrameworkCore;
using UserList.Models;

namespace UserList.Data
{

    public class AppDbContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}