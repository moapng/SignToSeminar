using Microsoft.EntityFrameworkCore;
using SignToSeminarBackEnd.Models;

namespace SignToSeminarBackEnd.Context
{
    public class STSDBContext : DbContext
    {
        public DbSet<SeminarModel> Seminars { set; get; }
        public DbSet<UserModel> Users { set; get; }

        public STSDBContext(DbContextOptions<STSDBContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MOAAAAAAAAA\SQLEXPRESS01;Database=SignToSeminarDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
