using Microsoft.EntityFrameworkCore;
using MNOServiceUpdateAPI.Models;

namespace MNOServiceUpdateAPI.DbContextData
{
    public class MNOServiceDbContext : DbContext
    {
        public MNOServiceDbContext(DbContextOptions<MNOServiceDbContext> options) : base(options) { }
        public DbSet<MNOServiceTable> MNOServiceTable { get; set; }
    }
}
