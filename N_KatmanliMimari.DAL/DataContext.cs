using Microsoft.EntityFrameworkCore;
using N_KatmanliMimari.Entity;

namespace N_KatmanliMimari.DAL
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-58CMK8T\\SQLDERS; Database=NTierDB; User Id=sa; Pwd=1; TrustServerCertificate=True;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
